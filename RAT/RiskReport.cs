using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAT
{
    public class RiskReport
    {
        public string RecordID { get; set; }
        public int Restages { get; set; }
        public int Program_Count { get; set; }
        public int Intersects { get; set; }
        public int TimeStamp { get; set; }
        public int Jira_Observations { get; set; }
        public int EffortLimit { get; set; }
        public double Risk_Percentage { get; set; }

    }
}
