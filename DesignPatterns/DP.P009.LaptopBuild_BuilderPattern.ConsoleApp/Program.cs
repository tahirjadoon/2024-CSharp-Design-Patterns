// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Builder Pattern implementation - Computer Build!");
ConsoleHelper.WriteEmptyLine();

BuildComputer("Gaming Computer", "Gaming", new BuilderGamingComputer());

ConsoleHelper.WriteEmptyLine();

BuildComputer("Basic Computer", "Basic", new BuilderBasicComputer());

ConsoleHelper.WriteEmptyLine();

void BuildComputer(string title, string computer, IComputerBuilder builder)
{
    ConsoleHelper.WriteLine($"Lets make a computer via {title}", ConsoleColor.Yellow);
    var director = new Director(builder);
    //following 2 are the same objects
    var computerToMake = director.Make();
    var computerToMake2 = builder.GetComputer();

    ConsoleHelper.WriteLine($"We just made a {computer} computer!");
    computerToMake.DisplaySpecifications();
}
