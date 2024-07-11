// See https://aka.ms/new-console-template for more information
using DP.BicycleBuildBase.Enums;
using DP.BicycleBuildBase;
using DP.Core;
using DP.Core.Extensions;
using DP.P005.BicycleBuild_SimpleFactoryPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Simple Factory Pattern implementation!");

const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";

if (args.Length <= 0)
{
    ConsoleHelper.ErrorWrite(errorText);
}
else
{
    var arg = args[0].Trim();

    var bicycleFactory = new SimpleBicycleFactory();
    var bikeToBuild = bicycleFactory.Create(arg);

    bikeToBuild.Build();
    ConsoleHelper.WriteEmptyLine();
    ConsoleHelper.SuccessWrite(bikeToBuild.ToString());
}
