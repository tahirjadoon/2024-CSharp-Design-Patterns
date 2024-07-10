// See https://aka.ms/new-console-template for more information
using DP.Core;
using DP.P003.DependencyInversionPrinciple.ConsoleApp;

ConsoleHelper.WriteLine("Dependency Inversion Principle - DIP", ConsoleColor.Magenta);
ConsoleHelper.WriteEmptyLine();

var lamp1 = new DIPLamp(new DIPButton());
ConsoleHelper.WriteLine("LAMP with button");
lamp1.ToggleLamp();
lamp1.ToggleLamp();

var lamp2 = new DIPLamp(new DIPMotionDetector());
ConsoleHelper.WriteLine("LAMP with MotionDetector");
lamp2.ToggleLamp();
lamp2.ToggleLamp();



