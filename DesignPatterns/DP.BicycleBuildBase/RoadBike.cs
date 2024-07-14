using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

/// <summary>
/// inherits from Bicycle abstract class
/// </summary>
public class RoadBike : Bicycle
{
    public RoadBike()
    {
        ModelName = ZBikeModelNames.Hillcrest;
        Suspension = ZSuspensionTypes.Hardtail;
        Color = ZBicyclePaintColors.Blue;
        Geometry = ZBicycleGeometries.Upright;
    }
}
