using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Brakes;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class BrakeTypeCoaster : AbstractBikeBrakes
{
    public BrakeTypeCoaster()
    {
        BrakeType = ZBicycleBrakeTypes.Coaster;
    }
}
