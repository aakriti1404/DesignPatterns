using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PdfReport : IReportBuilder
    {
        private Report reportObject;
        public void SetReportContent()
        {
            reportObject.ReportContent = "Pdf Content Section";
        }
        public void SetReportFooter()
        {
            reportObject.ReportFooter = "Pdf Footer";

        }
        public void SetReportHeader()
        {
            reportObject.ReportHeader = "Pdf Header";

        }
        public void SetReportType()
        {
            reportObject.ReportType = "Pdf";

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
