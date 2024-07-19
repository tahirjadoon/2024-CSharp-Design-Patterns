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
public class BuilderRecumbentBike : IBicycleBuilder
{
    private BicycleProduct _bicycle = null!;

    public BuilderRecumbentBike()
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
        _bicycle.Drivetrain = new DrivetrainRecumbentBike();//components
    }

    public void BuildFrame()
    {
        _bicycle.Frame = new FrameRecumbentBike();//components
    }

    public void BuildHandleBars()
    {
        _bicycle.Handlebars = new HandlebarsRecumbentBike();//components
    }

    public void BuildSeat()
    {
        _bicycle.Seat = new SeatRecumbentBike();//components
    }

    public void BuildSuspension()
    {
        _bicycle.Suspension = new SuspensionFront();//components
    }

    public IBicycleProduct GetProduct()
    {
        return _bicycle;
    }
}
