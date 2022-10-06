using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;


namespace CovidTrackerApplication.Models
{
    public class DailyDataRow
    {
        // Id of the dataset
        public int? Id { get; set; }

        // Date of the dataset
        public string date { get; set; }

        // State Abbreviation
        public string state { get; set; }

        // Total positive tests - cumulative
        public int? positive { get; set; }

        // Total negative tests - cumulative
        public int? negative { get; set; }

        // Total pending tests - cumulative
        public int? pending { get; set; }

        // Total number of tests administered - cumulative
        public int? totalTestResults { get; set; }

        // Number of patients in the hospital - current
        public int? hospitalizedCurrently { get; set; }

        // Number of patients in the hospital - cumulative
        public int? hospitalizedCumulative { get; set; }

        // Total death count
        public int? death { get; set; }

        public DailyDataRow()
        {
            positive = negative = pending =
                totalTestResults = hospitalizedCurrently =
                hospitalizedCumulative = death = 0;
            date = "20200101";
            state = "ZZ";
        }
    }
}