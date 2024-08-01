using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;

namespace DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

public abstract class AbstractBicycleDecorator : IBicycle
{
    //The protected field to hold the original IBicyle object is crucial here. This is the original,
    //undecorated object instance we’ll be decorating
    //The original Bicycle Class is not being touched
    protected readonly IBicycle _undecoratedBicycle;

    protected AbstractBicycleDecorator(IBicycle bicycle)
    {
        _undecoratedBicycle = bicycle;
    }

    public ZBikeModelNames ModelName 
    { 
        get => _undecoratedBicycle.ModelName; 
        set => _undecoratedBicycle.ModelName = value; 
    }

    public int Year => _undecoratedBicycle.Year;

    public string SerialNumber => _undecoratedBicycle.SerialNumber;

    public ZBicyclePaintColors Color 
    { 
        get => _undecoratedBicycle.Color; 
        set => _undecoratedBicycle.Color = value; 
    }
    
    public ZBicycleGeometries Geometry 
    { 
        get => _undecoratedBicycle.Geometry; 
        set => _undecoratedBicycle.Geometry = value; 
    }
    
    public ZSuspensionTypes Suspension 
    { 
        get => _undecoratedBicycle.Suspension; 
        set => _undecoratedBicycle.Suspension = value; 
    }

    public ZManufacturingStatus BuildStatus 
    { 
        get => _undecoratedBicycle.BuildStatus; 
        set => _undecoratedBicycle.BuildStatus = value; 
    }

    public abstract void Build();
}
