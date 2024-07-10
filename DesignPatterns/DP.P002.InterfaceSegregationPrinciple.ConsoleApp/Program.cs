// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.Core.Extensions;
using DP.P002.InterfaceSegregationPrinciple.ConsoleApp;

ConsoleHelper.WriteLine("Interface Segregation Priciple - ISP", ConsoleColor.Magenta);
ConsoleHelper.WriteEmptyLine();

var square = new ISPSquare() { Height = 2d, Width = 10d };
var squareResult = square.GetArea();
ConsoleHelper.WriteLine($"Square object: {square.ToJson()}");
ConsoleHelper.WriteLine($"Square Result: {squareResult}", ConsoleColor.Green);
ConsoleHelper.WriteEmptyLine();

var cube = new ISPCube() { Depth = 2d, Width = 10d, Height = 2d };
var cubeResult = cube.GetVolume();
ConsoleHelper.WriteLine($"Cube object: {cube.ToJson()}");
ConsoleHelper.WriteLine($"Cube Result: {cubeResult}", ConsoleColor.Green);


