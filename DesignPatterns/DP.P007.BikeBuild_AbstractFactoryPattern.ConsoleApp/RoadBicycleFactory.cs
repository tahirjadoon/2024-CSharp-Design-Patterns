using DP.BicycleBuildBase.Components.Brakes;
using DP.BicycleBuildBase.Components.Drivetrain;
using DP.BicycleBuildBase.Components.Frame;
using DP.BicycleBuildBase.Components.Handlebars;
using DP.BicycleBuildBase.Components.Seats;
using DP.BicycleBuildBase.Components.Suspensions;

namespace DP.P007.BikeBuild_AbstractFactoryPattern.ConsoleApp;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class RoadBicycleFactory : IBicycleFactory
{
    public IBikeBrakes CreateBicycleBrakes()
    {
        var brake = new BrakeTypeCaliper();
        return brake;
    }

    public IBikeDrivetrain CreateBicyleDrivetrain()
    {
        var drivetrain = new DrivetrainRoadBike();
        return drivetrain;
    }

    public IBikeFrame CreateBicycleFrame()
    {
        var frame = new FrameRoadBike();
        return frame;
    }

    public IBikeHandlebars CreateBicycleHandleBars()
    {
        var handleBars = new HandlebarsRoadBike();
        return handleBars;
    }

    public IBikeSeats CreateBicyleSeats()
    {
        var seat = new SeatGeneric();
        return seat;
    }

    public IBikeSuspension CreateBicycleSuspension()
    {
        var suspension = new SuspensionFront();
        return suspension;
    }
}
