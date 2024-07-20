namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public class BuilderPdfReport : ReportBuilder
{
    public override void SetReportContent()
    {
        _report.ReportContent = "PDF Content Section";
    }

    public override void SetReportFooter()
    {
        _report.ReportFooter = "PDF Footer";
    }

    public override void SetReportHeader()
    {
        _report.ReportHeader = "PDF Header";
    }

    public override void SetReportType()
    {
        _report.ReportType = "PDF";
    }
}
