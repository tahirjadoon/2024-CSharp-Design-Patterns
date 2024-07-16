namespace DP.BicycleBuildBase.Components.Suspensions;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public interface IBikeSuspension
{
    public bool HasFrontShock { get; set; }
    public bool HasRearShock { get; set; }
}
