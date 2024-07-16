namespace DP.BicycleBuildBase.Components.Suspensions;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class AbstractBikeSuspension : IBikeSuspension
{
    public bool HasFrontShock { get; set; }
    public bool HasRearShock { get; set; }

    public override string ToString()
    {
        var suspension = "Hardtail";

        if (HasFrontShock && !HasRearShock) suspension = "Front Suspension";

        if (HasFrontShock && HasRearShock) suspension = "Full Suspension";

        return $"Suspension chosen is {suspension}";
    }
}
