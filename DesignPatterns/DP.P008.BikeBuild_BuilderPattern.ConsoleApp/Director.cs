namespace DP.P008.BikeBuild_BuilderPattern.ConsoleApp;

/// <summary>
/// Created: 008-BikeBuild-BuilderPattern
/// </summary>
public class Director
{
    private IBicycleBuilder _builder;

    public Director(IBicycleBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBicycleBuilder builder)
    {
        _builder = builder;
    }

    public IBicycleProduct Make()
    {
        _builder.BuildFrame();
        _builder.BuildHandleBars();
        _builder.BuildSeat();
        _builder.BuildSuspension();
        _builder.BuildDriveTrain();
        _builder.BuildBrakes();
        return _builder.GetProduct();
    }
}
