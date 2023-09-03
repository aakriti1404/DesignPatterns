// See https://aka.ms/new-console-template for more information
namespace BuilderDesignPatternNew
{
    public class Program
    {
        static void Main(string[] args)
        {

            IReportBuilder excelReport = new ExcelReport();
            excelReport.SetReportType("Excel");
            excelReport.SetReportHeader("Excel Header");
            excelReport.SetReportContent("Excel Content");
            excelReport.SetReportFooter("Excel Footer");

            IReport excel = excelReport.GetReport();
            excel.Display();

            Console.WriteLine("----------------------------------------");

            IReportBuilder pdfReport = new PdfReport();
            pdfReport.SetReportType("PDF");
            pdfReport.SetReportContent("PDF Content");


            IReport pdf = pdfReport.GetReport();
            pdf.Display();
        }
    }
}

