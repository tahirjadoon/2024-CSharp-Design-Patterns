using DP.Core;

namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public class ReportProduct : IReportProduct
{
    public string ReportType { get; set; }
    public string ReportHeader { get; set; }
    public string ReportFooter { get; set; }
    public string ReportContent { get; set; }

    public void DisplayReport()
    {
        ConsoleHelper.WriteLine("\tReport Type :" + ReportType);
        ConsoleHelper.WriteLine("\tHeader :" + ReportHeader);
        ConsoleHelper.WriteLine("\tContent :" + ReportContent);
        ConsoleHelper.WriteLine("\tFooter :" + ReportFooter);
    }
}
