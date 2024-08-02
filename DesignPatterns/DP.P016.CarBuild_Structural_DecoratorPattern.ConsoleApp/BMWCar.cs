using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp;

public class BMWCar : ICar
{
    private string CarName = "BMW";

    public string CarBody { get; set; } = null!;
    public string CarDoor { get; set; } = null!;
    public string CarWheels { get; set; } = null!;
    public string CarGlass { get; set; } = null!;
    public string Engine { get; set; } = null!;

    
    //car without engine
    //engine will be via decorator
    public ICar ManufactureCar()
    {
        CarBody = "carbon fibre material";
        CarDoor = "4 car door";
        CarWheels = "6 car glasses";
        CarGlass = "4 MRF wheels";
        return this;
    }

    public override string ToString()
    {
        return $"{CarName} [ CarBody={CarBody}, CarDoor={CarDoor}, CarWheels={CarWheels}, CarGlass={CarGlass}, Engine={Engine ?? "NoEngine"}]";
    }
}
