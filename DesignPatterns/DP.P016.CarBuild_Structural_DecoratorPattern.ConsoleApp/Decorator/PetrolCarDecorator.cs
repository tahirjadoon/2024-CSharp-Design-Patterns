using DP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp.Decorator;

public class PetrolCarDecorator : CarDecorator
{
    public PetrolCarDecorator(ICar car) : base(car)
    {
    }

    public override ICar ManufactureCar()
    {
        base._car.ManufactureCar();
        AddEngine(_car);
        return base._car;
    }

    private void AddEngine(ICar car)
    {
        if(_car is BMWCar bmwcar)
        {
            bmwcar.Engine = "Petrol Engine";
            ConsoleHelper.WriteLine($"\tPetrolCarDecorator added Petrol Engine to the car: \n\t{_car}", ConsoleColor.Cyan);
        }
    }
}
