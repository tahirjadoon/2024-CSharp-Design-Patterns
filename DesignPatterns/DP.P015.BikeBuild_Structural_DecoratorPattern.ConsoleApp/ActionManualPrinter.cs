using DP.Core;

namespace DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

public class ActionManualPrinter : IDocumentor
{
    public void PrintManual()
    {
        ConsoleHelper.WriteLine("The manual is printing!", ConsoleColor.Yellow);
        ConsoleHelper.WriteEmptyLine();
    }
}
