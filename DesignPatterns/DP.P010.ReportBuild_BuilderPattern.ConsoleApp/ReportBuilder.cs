using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public abstract class ReportBuilder : IReportBuilder
{
    protected ReportProduct _report = null!;

    public void CreateNewReport()
    {
        _report = new ReportProduct();
    }

    public IReportProduct GetReport()
    {
        return _report;
    }

    public abstract void SetReportContent();

    public abstract void SetReportFooter();

    public abstract void SetReportHeader();

    public abstract void SetReportType();
}
