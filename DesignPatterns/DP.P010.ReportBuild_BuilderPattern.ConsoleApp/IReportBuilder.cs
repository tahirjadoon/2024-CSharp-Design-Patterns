namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public interface IReportBuilder
{
    void SetReportType();
    void SetReportHeader();
    void SetReportContent();
    void SetReportFooter();

    void CreateNewReport();
    IReportProduct GetReport();
}
