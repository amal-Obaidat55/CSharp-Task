using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolsystem_Task5
{
    internal sealed class SchoolReport
    {
        // The Sealed Class like to get not to share so we can't inherit from this class and when we try it's will lead error
        public string ReportTitle { get; set; }
        public SchoolReport(string title) {
            ReportTitle = title;
        }
        
        public void DisplayReportTitle()
        {
            Console.WriteLine($"Report Title : "+ReportTitle);
        }
    }
}
