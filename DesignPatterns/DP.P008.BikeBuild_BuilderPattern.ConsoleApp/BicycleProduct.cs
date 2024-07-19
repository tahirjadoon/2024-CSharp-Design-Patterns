using DP.BicycleBuildBase.Components.Brakes;
using DP.BicycleBuildBase.Components.Drivetrain;
using DP.BicycleBuildBase.Components.Frame;
using DP.BicycleBuildBase.Components.Handlebars;
using DP.BicycleBuildBase.Components.Seats;
using DP.BicycleBuildBase.Components.Suspensions;
using System.Text;

namespace DP.P008.BikeBuild_BuilderPattern.ConsoleApp;

/// <summary>
/// Created: 008-BikeBuild-BuilderPattern
/// </summary>
public class BicycleProduct : IBicycleProduct
{
    public IBikeBrakes Brakes { get; set; } = null!;
    public IBikeDrivetrain Drivetrain { get; set; } = null!;
    public IBikeFrame Frame { get; set; } = null!;
    public IBikeHandlebars Handlebars { get; set; } = null!;
    public IBikeSeats Seat { get; set; } = null!;
    public IBikeSuspension Suspension { get; set; } = null!;

    public override string ToString()
    {
        var fullDescription = new StringBuilder("Here's your new bicycle: ");
        if(Frame != null) fullDescription.AppendLine($"\r\n\tFrame = {Frame.ToString()}");
        if(Suspension != null) fullDescription.AppendLine($"\r\n\tSuspension = {Suspension.ToString()}");
        if(Handlebars != null) fullDescription.AppendLine($"\r\n\tHandlebars = {Handlebars.ToString()}");
        if(Drivetrain != null) fullDescription.AppendLine($"\r\n\tDrivetrain = {Drivetrain.ToString()}");
        if(Seat != null) fullDescription.AppendLine($"\r\n\tSeat = {Seat.ToString()}");
        if(Brakes != null) fullDescription.AppendLine($"\r\n\tBrakes = {Brakes.ToString()}");
        return fullDescription.ToString();
    }
}
