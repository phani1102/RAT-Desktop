using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace RAT
{
    public partial class Report : Form
    {
        public List<RiskFactor> riskFactorList = new List<RiskFactor>();
        public List<RiskReport> riskReportFinal;
        ProcessReport report;

        public Report()
        {
            InitializeComponent();
            report = new ProcessReport();
            riskReportFinal = new List<RiskReport>();

        }

        private void btnCalculateRisk_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lblErrorMessage.Visible = false;
            btnExport.Visible = false;
            dgvReportData.Visible = false;
             List<WorkEffort> workEffortListSorted  = new List<WorkEffort>();
            try
            {
                try
                {
                    var dataString = report.GetReportData(1, AppKeyHelper.WeURl.Replace("{{EndDate}}", dtpLoadDate.Value.ToString("yyyy-MM-dd")));

                    if (!string.IsNullOrEmpty(dataString))
                    {
                        List<WorkEffort> workEffortList = report.ConvertJSonToListObject<WorkEffort>(dataString);
                        workEffortListSorted = workEffortList.Where(s => s.LoadDate.Date == dtpLoadDate.Value.Date).ToList();


                        if (workEffortListSorted.Count > 0)
                        {

                            int calculated = 0;
                            double resMax = 10, pcMax = 15, intMax = 5, tsMax = 8, jiraMax = 10;
                            foreach (var item in riskFactorList)
                            {
                                double Jira = 0;

                                calculated = workEffortListSorted.Where(s => s.RecordID == item.RecordID).Select(s => { return report.GenerateTimeStamp(s.report); }).FirstOrDefault();

                                var objRiskreport = new RiskReport()
                                {
                                    RecordID = item.RecordID,
                                    Restages = item.riskFactors.restages,
                                    Program_Count = item.riskFactors.program,
                                    Intersects = item.riskFactors.intersects,
                                    Jira_Observations = 0,
                                    EffortLimit = Convert.ToInt32(AppKeyHelper.EffortLimit),
                                    TimeStamp = calculated
                                };

                                riskReportFinal.Add(objRiskreport);

                                if (item.riskFactors.intersects > intMax)
                                    intMax = item.riskFactors.intersects;
                                if (Jira > jiraMax)
                                    jiraMax = Jira;
                                if (item.riskFactors.program > pcMax)
                                    pcMax = item.riskFactors.program;
                                if (item.riskFactors.restages > resMax)
                                    resMax = item.riskFactors.restages;
                                if (objRiskreport.TimeStamp > tsMax)
                                    tsMax = objRiskreport.TimeStamp;
                            }

                            foreach (var item in riskReportFinal)
                            {

                                item.Risk_Percentage = ((item.Intersects / intMax + item.Jira_Observations / jiraMax + item.Program_Count / pcMax + item.Restages / resMax + item.TimeStamp / tsMax) * 100 / 5);
                            }
                            //Grid Binding

                            var reportDataTable = report.ConvertToDataTable(riskReportFinal);
                            dgvReportData.Visible = true;
                            dgvReportData.DataSource = reportDataTable;
                            btnExport.Visible = true;
                        }
                        else
                        {
                            lblErrorMessage.Text = "No Work Efforts Logged";
                            lblErrorMessage.Visible = true;
                        }
                    }
                    else
                    {
                        lblErrorMessage.Text = "Failed to Load WE Data from the service";
                        lblErrorMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblErrorMessage.Text = "Failed to Load WE Data from the service";
                    lblErrorMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            GetRiskFactorList();
        }

        private void dtpLoadDate_ValueChanged(object sender, EventArgs e)
        {

            GetRiskFactorList();
        }

        public void GetRiskFactorList()
        {
            try
            {
                var dataString = report.GetReportData(2, AppKeyHelper.HistoryUrl.Replace("{{EndDate}}", dtpLoadDate.Value.ToString("yyyy-MM-dd")));
                if (!string.IsNullOrEmpty(dataString))
                {
                    riskFactorList = report.ConvertJSonToListObject<RiskFactor>(dataString);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void dgvReportData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvReportData.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDouble(Myrow.Cells[6].Value) > Convert.ToDouble(AppKeyHelper.EffortLimit))// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                    Myrow.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
