namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public class BuilderExcelReport : ReportBuilder
{
    public override void SetReportContent()
    {
        _report.ReportContent = "Excel Content Section";
    }

    public override void SetReportFooter()
    {
        _report.ReportFooter = "Excel Footer";
    }

    public override void SetReportHeader()
    {
        _report.ReportHeader = "Excel Header";
    }

    public override void SetReportType()
    {
        _report.ReportType = "Excel";
    }
}
