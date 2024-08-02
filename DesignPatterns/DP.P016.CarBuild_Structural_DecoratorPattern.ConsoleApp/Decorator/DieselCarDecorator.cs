
using DP.Core;

namespace DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp.Decorator;

public class DieselCarDecorator : CarDecorator
{
    public DieselCarDecorator(ICar car) : base(car)
    {
    }

    public override ICar ManufactureCar()
    {
        base._car.ManufactureCar();
        AddEngine(base._car.ManufactureCar());
        return base._car;
    }

    private void AddEngine(ICar car)
    {
        if(car is BMWCar bmwcar)
        {
            bmwcar.Engine = "Diesel Engine";
            ConsoleHelper.WriteLine($"\tDieselCarDecorator added Diesel Engine to the car: \n\t{_car}", ConsoleColor.Cyan);
        }
    }
}
