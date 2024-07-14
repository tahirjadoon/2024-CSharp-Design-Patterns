using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

/// <summary>
/// inherits from Bicycle abstract class
/// </summary>
public class MountainBike : Bicycle
{
    public MountainBike()
    {
        ModelName = ZBikeModelNames.PaloDuroCanyonRanger;
        Suspension = ZSuspensionTypes.Full;
        Color = ZBicyclePaintColors.Black;
        Geometry = ZBicycleGeometries.Upright;
    }
}
