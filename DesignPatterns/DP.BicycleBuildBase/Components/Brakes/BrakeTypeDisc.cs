using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Brakes;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class BrakeTypeDisc : AbstractBikeBrakes
{
    public BrakeTypeDisc()
    {
        BrakeType = ZBicycleBrakeTypes.Disc;
    }
}
