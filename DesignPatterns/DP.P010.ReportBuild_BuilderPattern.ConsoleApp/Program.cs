// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P010.ReportBuild_BuilderPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Builder Pattern implementation - Report Build!");
ConsoleHelper.WriteEmptyLine();

BuildReport("BuilderExcelReport", new BuilderExcelReport());
ConsoleHelper.WriteEmptyLine();

BuildReport("BuilderPdfReport", new BuilderPdfReport());
ConsoleHelper.WriteEmptyLine();

void BuildReport(string title, ReportBuilder builder)
{
    ConsoleHelper.WriteLine($"Lets make a report via {title}", ConsoleColor.Yellow);

    var director = new Director();
    var reportToMake = director.MakeReport(builder);
    reportToMake.DisplayReport();
}