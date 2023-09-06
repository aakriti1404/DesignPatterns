using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternNew
{
    public interface IReportBuilder
    {
        void SetReportType(string reportType);
        void SetReportHeader(string reportHeader);
        void SetReportContent(string reportContent);
        void SetReportFooter(string reportFooter);
        IReport GetReport();


    }
}
