// See https://aka.ms/new-console-template for more information
using DP.BicycleBuildBase.Enums;
using DP.Core;
using DP.Core.Extensions;
using DP.P006.BicycleBuild_FactoryMethodPattern.ConsoleApp;

ConsoleHelper.TitleWrite("Factory Methd Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("Lets make a bike via DallasCreator", ConsoleColor.Yellow);
var dallasCreator = new DallasCreator();
var hillcrest = dallasCreator.CreateProduct(ZBikeModelNames.Hillcrest);
hillcrest.Build();

ConsoleHelper.WriteEmptyLine();
ConsoleHelper.WriteLine("Lets make a bike via AlpineCreator", ConsoleColor.Yellow);
var alpineCreator = new AlpineCreator();
var paloDuroCanyonRanger = alpineCreator.CreateProduct(ZBikeModelNames.PaloDuroCanyonRanger);
paloDuroCanyonRanger.Build();
