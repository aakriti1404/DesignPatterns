using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternNew
{
    public class Report :IReport
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }
        public void Display()
        {
            Console.WriteLine("Report features: ");
            if (!string.IsNullOrEmpty(ReportType)) Console.WriteLine("Report type: " + ReportType);
            if (!string.IsNullOrEmpty(ReportHeader)) Console.WriteLine("Report header: " + ReportHeader);
            if (!string.IsNullOrEmpty(ReportContent)) Console.WriteLine("Report content: " + ReportContent);
            if (!string.IsNullOrEmpty(ReportFooter)) Console.WriteLine("Report footer: " + ReportFooter);

        }
    }
}
