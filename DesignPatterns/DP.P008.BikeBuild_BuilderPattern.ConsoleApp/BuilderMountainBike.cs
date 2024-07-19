using DP.BicycleBuildBase.Components.Brakes;
using DP.BicycleBuildBase.Components.Drivetrain;
using DP.BicycleBuildBase.Components.Frame;
using DP.BicycleBuildBase.Components.Handlebars;
using DP.BicycleBuildBase.Components.Seats;
using DP.BicycleBuildBase.Components.Suspensions;

namespace DP.P008.BikeBuild_BuilderPattern.ConsoleApp;

/// <summary>
/// Created: 008-BikeBuild-BuilderPattern
/// </summary>
public class BuilderMountainBike : IBicycleBuilder
{
    private BicycleProduct _bicycle = null!;

    public BuilderMountainBike()
    {
        Reset();
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = new BrakeTypeDisc(); //components
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new DrivetrainMountainBike();//components
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new FrameMountainBike();//components
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new HandlebarsMountianBike();//components
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new SeatGeneric();//components
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new SuspensionFull();//components
    }

    public IBicycleProduct GetProduct()
    {
        return _bicycle;
    }
}
