// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.Core.Extensions;
using DP.P014.BikeBuild_SingletonPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Sigleton Pattern implementation on top of Object Pool Pattern - Welding Arms!");
ConsoleHelper.WriteEmptyLine();

//var armPool = new WeldingArmPoolSingleton { MaxSize = 10 };
var armPool = WeldingArmPoolSingleton.Instance;
armPool.MaxSize = 10;
ConsoleHelper.WriteLine($"Pool size: {armPool.ArmsAvailable}", ConsoleColor.Cyan);
ConsoleHelper.WriteEmptyLine();

var arm01 = armPool.GetArmFromPool();
ConsoleHelper.WriteLine($"Pool size after picking arm01: {armPool.ArmsAvailable}", ConsoleColor.Cyan);
arm01.MoveToStation(1);
ConsoleHelper.WriteLine("arm01 before DoWeld", ConsoleColor.Yellow);
ConsoleHelper.WriteLine($"\t{arm01.ToJson()}");
ConsoleHelper.WriteEmptyLine();

var result = arm01.DoWeld();
ConsoleHelper.WriteLine("arm01 after DoWeld", ConsoleColor.Yellow);
ConsoleHelper.WriteLine($"\t{arm01.ToJson()}");
ConsoleHelper.WriteEmptyLine();

if (result)
{
    armPool.ReturnArmToPool(arm01);
}

ConsoleHelper.WriteLine($"Pool size after return: {armPool.ArmsAvailable}", ConsoleColor.Cyan);
ConsoleHelper.WriteEmptyLine();
