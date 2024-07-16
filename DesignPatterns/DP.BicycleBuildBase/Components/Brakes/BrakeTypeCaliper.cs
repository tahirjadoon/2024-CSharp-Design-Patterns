using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Brakes;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class BrakeTypeCaliper : AbstractBikeBrakes
{
    public BrakeTypeCaliper()
    {
        BrakeType = ZBicycleBrakeTypes.Caliper;
    }
}
