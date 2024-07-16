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
public class MountainBicycleFactory : IBicycleFactory
{
    public IBikeBrakes CreateBicycleBrakes()
    {
        var brake = new BrakeTypeDisc();
        return brake;
    }

    public IBikeDrivetrain CreateBicyleDrivetrain()
    {
        var drivetrain = new DrivetrainMountainBike();
        return drivetrain;
    }

    public IBikeFrame CreateBicycleFrame()
    {
        var frame = new FrameMountainBike();
        return frame;
    }

    public IBikeHandlebars CreateBicycleHandleBars()
    {
        var handleBars = new HandlebarsMountianBike();
        return handleBars;
    }

    public IBikeSeats CreateBicyleSeats()
    {
        var seat = new SeatGeneric();
        return seat;
    }

    public IBikeSuspension CreateBicycleSuspension()
    {
        var suspension = new SuspensionFull();
        return suspension;
    }
}
