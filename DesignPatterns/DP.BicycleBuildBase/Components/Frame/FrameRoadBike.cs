using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Frame;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// this is actualy the same class as RoadBike class
/// not overwriting the original hence re-created as a component so that project 4, 5 and 6 do not break
/// </summary>
public class FrameRoadBike : AbstractBikeFrame
{
    public FrameRoadBike()
    {
        ModelName = ZBikeModelNames.Hillcrest;
        Suspension = ZSuspensionTypes.Hardtail;
        Color = ZBicyclePaintColors.Blue;
        Geometry = ZBicycleGeometries.Upright;
    }
}
