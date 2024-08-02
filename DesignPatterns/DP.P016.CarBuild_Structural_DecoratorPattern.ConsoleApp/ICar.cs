namespace DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp;

public interface ICar
{
    //This is the Base Component that defines operations that can be altered by decorators.
    ICar ManufactureCar();
}
