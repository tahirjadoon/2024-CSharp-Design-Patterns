// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P007.BikeBuild_AbstractFactoryPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Abstract Factory Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

IBicycleFactory roadBikeFactory = new RoadBicycleFactory();
BuildBike("RoadBicycleFactory", "road", roadBikeFactory);

ConsoleHelper.WriteEmptyLine();
IBicycleFactory mountainBikeFactory = new MountainBicycleFactory();
BuildBike("MountainBicycleFactory", "mountain", mountainBikeFactory);

ConsoleHelper.WriteEmptyLine();
IBicycleFactory crusierBikeFactory = new CrusierBicycleFactory();
BuildBike("CrusierBicycleFactory", "crusier", crusierBikeFactory);

ConsoleHelper.WriteEmptyLine();
IBicycleFactory recumbentBikeFactory = new RecumbentBicycleFactory();
BuildBike("RecumbentBikeFactory", "recumbent", recumbentBikeFactory);

void BuildBike(string bikeTitle, string bike, IBicycleFactory bicycleFactory)
{
    ConsoleHelper.WriteLine($"Lets make a bike via {bikeTitle}", ConsoleColor.Yellow);
    var frame = bicycleFactory.CreateBicycleFrame();
    var handlebars = bicycleFactory.CreateBicycleHandleBars();
    var brakes = bicycleFactory.CreateBicycleBrakes();
    var drivetrain = bicycleFactory.CreateBicyleDrivetrain();
    var seat = bicycleFactory.CreateBicyleSeats();
    var suspension = bicycleFactory.CreateBicycleSuspension();

    ConsoleHelper.WriteLine($"We just made a {bike} bike!");
    ConsoleHelper.WriteLine(frame.ToString()!);
    ConsoleHelper.WriteLine(handlebars.ToString()!);
    ConsoleHelper.WriteLine(brakes.ToString()!);
    ConsoleHelper.WriteLine(drivetrain.ToString()!);
    ConsoleHelper.WriteLine(seat.ToString()!);
    ConsoleHelper.WriteLine(suspension.ToString()!);
}