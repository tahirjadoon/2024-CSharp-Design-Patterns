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
public interface IBicycleProduct
{
    public IBikeBrakes Brakes { get; set; }
    public IBikeDrivetrain Drivetrain { get; set; }
    public IBikeFrame Frame { get; set; }
    public IBikeHandlebars Handlebars { get; set; }
    public IBikeSeats Seat { get; set; }
    public IBikeSuspension Suspension { get; set; }
}
