// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P001.OpenClosePrinciple.ConsoleApp;

ConsoleHelper.WriteLine("Open Close Principle - OCP");

var areaCalculator = new OCPAreaCalculator();

areaCalculator.AddShape(new OCPCircle(5d));
areaCalculator.AddShape(new OCPSquare(10d));
areaCalculator.AddShape(new OCPRectangle(5d, 10d));

ConsoleHelper.WriteLine($"Area : {areaCalculator.Area}", ConsoleColor.Green);