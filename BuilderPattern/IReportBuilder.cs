using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IReportBuilder : IReportType, IReportHeader, IReportContent, IReportFooter
    {
        Report GetReport();
        void CreateNewReport();
    }
}
