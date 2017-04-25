using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RAT
{
    public class AppKeyHelper
    {
        public AppKeyHelper()
        {
        }

        private static string GetAppValue(string key)
        {
            try
            {
                if (ConfigurationManager.AppSettings.HasKeys())
                {
                    if (ConfigurationManager.AppSettings[key] != null)
                    {
                        return Convert.ToString(ConfigurationManager.AppSettings[key]);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return string.Empty;
        }

        public static string RunMode
        {
            get { return GetAppValue("RunMode"); }
        }
        public static string WeURl
        {
            get { return GetAppValue("WeURl"); }
        }
        public static string HistoryUrl
        {
            get { return GetAppValue("HistoryUrl"); }
        }

        public static string DataPath
        {
            get { return GetAppValue("DataPath"); }
        }

        public static string EffortLimit
        {
            get { return GetAppValue("EffortLimit"); }
        }
    }

    //public enum AppRunMode
    //{
    //    Local = "Local",
    //    Service = "Service"
    //}
}
