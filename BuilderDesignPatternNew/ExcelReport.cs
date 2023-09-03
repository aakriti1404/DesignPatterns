using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternNew
{
    public class ExcelReport : IReportBuilder
    {
        private Report reportObject=new Report();

        public void SetReportType(string reportType)
        {
            reportObject.ReportType = reportType;
        }
        public void SetReportHeader(string reportHeader)
        {
            reportObject.ReportHeader = reportHeader;
        }
        public void SetReportContent(string reportContent)
        {
            reportObject.ReportContent = reportContent;
        }
        public void SetReportFooter(string reportFooter)
        {
            reportObject.ReportFooter = reportFooter;
        }
        public IReport GetReport()
        {
            return reportObject;
        }
    }
}
