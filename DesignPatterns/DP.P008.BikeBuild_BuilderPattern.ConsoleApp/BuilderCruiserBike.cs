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
public class BuilderCruiserBike : IBicycleBuilder
{
    private BicycleProduct _bicycle = null!;

    public BuilderCruiserBike()
    {
        Reset();
    }

    public void Reset()
    {
        _bicycle = new BicycleProduct();
    }

    public void BuildBrakes()
    {
        _bicycle.Brakes = new BrakeTypeCaliper(); //components
    }

    public void BuildDriveTrain()
    {
        _bicycle.Drivetrain = new DrivetrainCrusierBike();//components
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new FrameCruiserBike();//components
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new HandlebarsCruiserBike();//components
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new SeatCrusierBike();//components
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new SuspensionHardTail();//components
    }

    public IBicycleProduct GetProduct()
    {
        return _bicycle;
    }
}
