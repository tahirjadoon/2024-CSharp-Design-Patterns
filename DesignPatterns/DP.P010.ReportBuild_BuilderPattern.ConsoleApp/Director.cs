using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

public class Director
{
    public IReportProduct MakeReport(ReportBuilder builder)
    {
        builder.CreateNewReport();

        builder.SetReportType();
        builder.SetReportHeader();
        builder.SetReportContent();
        builder.SetReportFooter();

        return builder.GetReport();

    }
}
