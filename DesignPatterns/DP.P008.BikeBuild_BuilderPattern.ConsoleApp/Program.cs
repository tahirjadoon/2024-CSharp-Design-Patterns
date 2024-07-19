// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P008.BikeBuild_BuilderPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Builder Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

BuildBike("BuilderCruiserBike", "Cruiser", new BuilderCruiserBike());
ConsoleHelper.WriteEmptyLine();

BuildBike("BuilderMountainBike", "Mountain", new BuilderMountainBike());
ConsoleHelper.WriteEmptyLine();

BuildBike("BuilderRecumbentBike", "Recumbent", new BuilderRecumbentBike());
ConsoleHelper.WriteEmptyLine();

BuildBike("BuilderRoadBike", "Road", new BuilderRoadBike());
ConsoleHelper.WriteEmptyLine();

void BuildBike(string bikeTitle, string bike, IBicycleBuilder builder)
{
    ConsoleHelper.WriteLine($"Lets make a bike via {bikeTitle}", ConsoleColor.Yellow);
    var director = new Director(builder);
    var make = director.Make();
    ConsoleHelper.WriteLine($"We just made a {bike} bike!");
    Console.WriteLine(make.ToString());
}
