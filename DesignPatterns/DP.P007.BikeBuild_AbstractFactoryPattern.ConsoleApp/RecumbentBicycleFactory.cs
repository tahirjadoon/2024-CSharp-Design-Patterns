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
public class RecumbentBicycleFactory : IBicycleFactory
{
    public IBikeBrakes CreateBicycleBrakes()
    {
        var brake = new BrakeTypeCoaster();
        return brake;
    }

    public IBikeDrivetrain CreateBicyleDrivetrain()
    {
        var drivetrain = new DrivetrainRecumbentBike();
        return drivetrain;
    }

    public IBikeFrame CreateBicycleFrame()
    {
        var frame = new FrameRecumbentBike();
        return frame;
    }

    public IBikeHandlebars CreateBicycleHandleBars()
    {
        var handleBars = new HandlebarsRecumbentBike();
        return handleBars;
    }

    public IBikeSeats CreateBicyleSeats()
    {
        var seat = new SeatRecumbentBike();
        return seat;
    }

    public IBikeSuspension CreateBicycleSuspension()
    {
        var suspension = new SuspensionHardTail();
        return suspension;
    }
}
