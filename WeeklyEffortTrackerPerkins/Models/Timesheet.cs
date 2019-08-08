using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeklyEffortTrackerPerkins.Models
{
    public class Timesheet
    {
        public string associate { get; set; }
        public string month { get; set; }
        public List<string> weekDate { get; set; }
        public string project { get; set; }
        public string task { get; set; }
        public string tasktype { get; set; }
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
    }
}