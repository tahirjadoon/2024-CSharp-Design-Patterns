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
public class CrusierBicycleFactory : IBicycleFactory
{
    public IBikeBrakes CreateBicycleBrakes()
    {
        var brake = new BrakeTypeCaliper();
        return brake;
    }

    public IBikeDrivetrain CreateBicyleDrivetrain()
    {
        var drivetrain = new DrivetrainCrusierBike();
        return drivetrain;
    }

    public IBikeFrame CreateBicycleFrame()
    {
        var frame = new FrameCruiserBike();
        return frame;
    }

    public IBikeHandlebars CreateBicycleHandleBars()
    {
        var handleBars = new HandlebarsCruiserBike();
        return handleBars;
    }

    public IBikeSeats CreateBicyleSeats()
    {
        var seat = new SeatCrusierBike();
        return seat;
    }

    public IBikeSuspension CreateBicycleSuspension()
    {
        var suspension = new SuspensionFull();
        return suspension;
    }
}
