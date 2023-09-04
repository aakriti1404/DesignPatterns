using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ExcelReport : IReportBuilder
    {
        private Report reportObject;
        public void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }
        public void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";

        }
        public void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";

        }
        public void SetReportType()
        {
            reportObject.ReportType = "Excel";

        }
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
