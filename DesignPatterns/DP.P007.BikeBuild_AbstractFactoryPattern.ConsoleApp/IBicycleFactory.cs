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
public interface IBicycleFactory
{
    public IBikeBrakes CreateBicycleBrakes();
    public IBikeDrivetrain CreateBicyleDrivetrain();
    public IBikeFrame CreateBicycleFrame();
    public IBikeHandlebars CreateBicycleHandleBars();
    public IBikeSeats CreateBicyleSeats();
    public IBikeSuspension CreateBicycleSuspension();
}
