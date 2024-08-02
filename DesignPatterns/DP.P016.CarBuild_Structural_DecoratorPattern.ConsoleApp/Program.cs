// See https://aka.ms/new-console-template for more information
// https://dotnettutorials.net/lesson/decorator-design-pattern/
using DP.Core;
using DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp;
using DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp.Decorator;

ConsoleHelper.TitleWrite("CarBuild - Decorator Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("bmwCar1 concreate Component");
ICar bmwCar1 = new BMWCar();
bmwCar1.ManufactureCar();
ConsoleHelper.WriteLine($"\t{bmwCar1}", ConsoleColor.Yellow);

ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("Adding Diesel Engine to the bmwCar1");
DieselCarDecorator withDieselEngine = new DieselCarDecorator(bmwCar1);
withDieselEngine.ManufactureCar();

ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("bmwCar2 concreate Component and PetrolCarDecorator use");
ICar bmwCar2 = new BMWCar();
PetrolCarDecorator withPetrolEngine = new PetrolCarDecorator(bmwCar2);
withPetrolEngine.ManufactureCar();


