namespace DP.BicycleBuildBase.Components.Suspensions;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SuspensionFront : AbstractBikeSuspension
{
    public SuspensionFront()
    {
        HasFrontShock = true;
        HasRearShock = false;
    }
}
