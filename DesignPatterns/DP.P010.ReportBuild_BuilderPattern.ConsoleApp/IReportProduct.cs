namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public interface IReportProduct
{
    public string ReportType { get; set; }
    public string ReportHeader { get; set; }
    public string ReportFooter { get; set; }
    public string ReportContent { get; set; }

    void DisplayReport();
}
