// See https://aka.ms/new-console-template for more information
using DP.BicycleBuildBase;
using DP.Core;
using DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Decorator Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("Regular no decorator", ConsoleColor.Red);
var regRoadBike = new RoadBike();
regRoadBike.Build();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("DeoratorDocumentedBicycle with ActionManualPrinter", ConsoleColor.Green);
var bikeManualPrinter = new ActionManualPrinter();
var documentBike = new DecoratorDocumentedBicycle(new RoadBike(), bikeManualPrinter);
documentBike.Build();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("DeoratorNotifyingBicycle with ActionMaterialInvNotifier", ConsoleColor.Green);
var manuaInvNotifier = new ActionMaterialInvNotifier();
var notifierBike = new DecoratorNotifyingBicycle(new RoadBike(), manuaInvNotifier);
notifierBike.Build();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("Combining DeoratorDocumentedBicycle and DeoratorNotifyingBicycle", ConsoleColor.Green);
var bikeManualPrinter2 = new ActionManualPrinter();
var documentBike2 = new DecoratorDocumentedBicycle(new RoadBike(), bikeManualPrinter2);

var manuaInvNotifier2 = new ActionMaterialInvNotifier();

var notifyingDocumentBike = new DecoratorNotifyingBicycle(documentBike2, manuaInvNotifier2);
notifyingDocumentBike.Build();



