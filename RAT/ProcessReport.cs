using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.ComponentModel;

namespace RAT
{
    public class ProcessReport
    {
        public int[] GetDiffInHrsMinutes(DateTime date1, DateTime date2)
        {
            TimeSpan span = date2 - date1;
            return new int[] { Convert.ToInt32(Math.Floor(span.TotalHours)), span.Minutes };
        }

        public int GenerateTimeStamp(List<WEUserComment> reportData)
        {
            int totalRegHr = 672, totalFunHr = 160, timeStampValue = 0;
            bool devReadyState = false, scmReadyState = false, StartReadingTime = false;
            double totalDevHrs = 0,
                totalDevMin = 0,
                totalTestHr = 0,
                totalTestMin = 0,
                totalScmHrs = 0,
                totalScmMin = 0,
                actualTestMin = 0,
                actualDevMin = 0,
                actualScmMin = 0,
                actualTestHrs = 0,
                actualDevHrs = 0,
                actualScmHrs = 0;
            List<DateTime> devQueueStart = new List<DateTime>();
            List<DateTime> devQueueEnd = new List<DateTime>();
            List<DateTime> scmStart = new List<DateTime>();
            List<DateTime> scmEnd = new List<DateTime>();


            foreach (var item in reportData)
            {
                var str = item.Comment;
                if (str.Contains("QA Ready"))
                {
                    if (scmReadyState)
                    {
                        scmEnd.Add(item.Date);
                        scmReadyState = false;
                    }
                    StartReadingTime = true;
                }
                else if (str.Contains("SCM Build Ready"))
                {
                    if (StartReadingTime)
                    {
                        if (!scmReadyState)
                        {
                            scmStart.Add(item.Date); ;
                            scmReadyState = true;
                        }
                        if (devReadyState)
                        {
                            devQueueEnd.Add(item.Date);
                            devReadyState = false;
                        }
                    }
                }
                else if (str.Contains("DEV Working"))
                {
                    if (StartReadingTime)
                    {
                        if (!devReadyState)
                        {
                            devQueueStart.Add(item.Date);
                            devReadyState = true;
                        }
                        if (scmReadyState)
                        {
                            scmEnd.Add(item.Date);
                            scmReadyState = false;
                        }
                    }
                }
                else if (str.Contains("SCM Build Complete"))
                {
                    if (StartReadingTime)
                    {
                        if (scmReadyState)
                        {
                            scmEnd.Add(item.Date);
                            scmReadyState = false;
                        }
                    }
                }
                else if (str.Contains("Cancelled"))
                {
                    if (StartReadingTime)
                    {
                        if (devReadyState)
                        {
                            devQueueEnd.Add(item.Date);
                            devReadyState = false;
                        }
                    }
                }
                else if (str.Contains("SCM Loadset Ready"))
                {
                    if (StartReadingTime)
                    {
                        if (scmReadyState)
                        {
                            scmEnd.Add(item.Date);
                            scmReadyState = false;
                        }
                    }
                }
            }


            if (scmReadyState)
            {
                scmEnd.Add(DateTime.Now);
                scmReadyState = false;
            }
            if (devReadyState)
            {
                devQueueEnd.Add(DateTime.Now);
                devReadyState = false;
            }


            for (int index = 0; index < devQueueStart.Count; index++)
            {
                var differnce = GetDiffInHrsMinutes(devQueueStart[index], devQueueEnd[index]);
                totalDevHrs += differnce[0];
                totalDevMin += differnce[1];
            }
            for (int index = 0; index < scmStart.Count; index++)
            {
                var differnce = GetDiffInHrsMinutes(scmStart[index], scmEnd[index]);
                totalScmHrs += differnce[0];
                totalScmMin += differnce[1];
            }


            if (totalDevMin >= 60)
            {
                totalDevHrs = totalDevHrs + Math.Floor(totalDevMin / 60);
                totalDevMin = totalDevMin % 60;
            }


            if (totalScmMin >= 60)
            {
                totalScmHrs = totalScmHrs + Math.Floor(totalScmMin / 60);
                totalScmMin = totalScmMin % 60;
            }

            if (Math.Round(totalDevHrs / 24 * 8) < 8)
            {
                actualDevMin = totalDevMin;
                actualDevHrs = totalDevHrs;
            }
            else
            {
                actualDevHrs = Math.Round(totalDevHrs / 24 * 8);
            }
            if (Math.Round(totalScmHrs / 24 * 8) < 8)
            {
                actualScmMin = totalScmMin;
                actualScmHrs = totalScmHrs;
            }
            else
            {
                actualScmHrs = Math.Round(totalScmHrs / 24 * 8);
            }
            //QA Func_hrs = Total hrs – Non QA Hrs (Dev+SCM)
            totalTestHr = totalRegHr - (totalDevHrs + totalScmHrs);
            actualTestHrs = totalFunHr - (actualDevHrs + actualScmHrs);

            totalTestMin = totalDevMin + totalScmMin;
            if (totalTestMin >= 60)
            {
                totalTestHr = totalTestHr - Math.Floor(totalTestMin / 60);
                totalTestMin = 60 - totalTestMin % 60;
            }
            else
            {
                if (totalTestMin > 0)
                    totalTestMin = 60 - totalTestMin;
            }

            actualTestMin = actualDevMin + actualScmMin;
            if (actualTestMin >= 60)
            {
                actualTestHrs = actualTestHrs - Math.Floor(actualTestMin / 60);
                actualTestMin = 60 - actualTestMin % 60;
            }
            else
            {
                if (actualTestMin > 0)
                    actualTestMin = 60 - actualTestMin;
            }


            if (totalRegHr == totalTestHr)
            {
                totalTestMin = 0;
            }
            if (totalFunHr == actualTestHrs)
            {
                actualTestMin = 0;
            }
            if (actualTestHrs <= 20)
                timeStampValue = 8;
            if (actualTestHrs > 20 && actualTestHrs <= 40)
                timeStampValue = 7;
            if (actualTestHrs > 40 && actualTestHrs <= 60)
                timeStampValue = 6;
            if (actualTestHrs > 60 && actualTestHrs <= 80)
                timeStampValue = 5;
            if (actualTestHrs > 80 && actualTestHrs <= 100)
                timeStampValue = 4;
            if (actualTestHrs > 100 && actualTestHrs <= 120)
                timeStampValue = 3;
            if (actualTestHrs > 120 && actualTestHrs <= 140)
                timeStampValue = 2;
            if (actualTestHrs > 140)
                timeStampValue = 1;
            return timeStampValue;
        }

        public string GetReportData(int typeOfData = 1, string url = "")
        {
            string strJsonData = string.Empty;
            try
            {
                if (AppKeyHelper.RunMode == "Local")
                {
                    string path = string.Empty;
                    if (typeOfData == 1)
                        path = Path.Combine(AppKeyHelper.DataPath, "we.json");
                    else
                        path = Path.Combine(AppKeyHelper.DataPath, "riskFactor.json");
                    using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        strJsonData = reader.ReadToEnd();
                    }
                }
                else
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream receiveStream = response.GetResponseStream();
                        StreamReader readStream = null;

                        if (response.CharacterSet == null)
                        {
                            readStream = new StreamReader(receiveStream);
                        }
                        else
                        {
                            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                        }

                        strJsonData = readStream.ReadToEnd();
                        response.Close();
                        readStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                strJsonData = null;
            }
            return strJsonData;
        }

        public List<T> ConvertJSonToListObject<T>(string dataStr)
        {
            List<T> dataList = new List<T>();
            try
            {
                dataList = JsonConvert.DeserializeObject<List<T>>(dataStr);
            }
            catch (Exception ex)
            {
                dataList = null;
            }
            return dataList;

        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
