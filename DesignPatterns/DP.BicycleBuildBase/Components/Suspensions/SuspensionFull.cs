namespace DP.BicycleBuildBase.Components.Suspensions;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SuspensionFull : AbstractBikeSuspension
{
    public SuspensionFull()
    {
        HasFrontShock = true;
        HasRearShock = true;
    }
}
