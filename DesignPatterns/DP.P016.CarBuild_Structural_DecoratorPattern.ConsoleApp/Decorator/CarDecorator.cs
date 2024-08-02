namespace DP.P016.CarBuild_Structural_DecoratorPattern.ConsoleApp.Decorator;

public abstract class CarDecorator : ICar
{
    //Create a Field to store the Concrete Component
    protected ICar _car;

    //We need to pass the existing car object which we want to decorate
    protected CarDecorator(ICar car)
    {
        _car = car;
    }

    public virtual ICar ManufactureCar()
    {
        //Call the Existing Car Object ManufactureCar method to return the car without engine
        //Later in the Child class of this abstract we will see how to call this method 
        return _car.ManufactureCar();
    }
}
