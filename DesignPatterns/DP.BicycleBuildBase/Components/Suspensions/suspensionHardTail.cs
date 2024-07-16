namespace DP.BicycleBuildBase.Components.Suspensions;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SuspensionHardTail : AbstractBikeSuspension
{
    public SuspensionHardTail()
    {
        HasFrontShock = false;
        HasRearShock = false;
    }
}
