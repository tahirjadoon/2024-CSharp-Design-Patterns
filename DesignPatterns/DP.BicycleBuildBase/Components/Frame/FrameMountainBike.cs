using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Frame;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// this is actualy the same class as CruiserBike class
/// not overwriting the original hence re-created as a component so that project 4, 5 and 6 do not break
/// </summary>
public class FrameMountainBike : AbstractBikeFrame
{
    public FrameMountainBike()
    {
        ModelName = ZBikeModelNames.PaloDuroCanyonRanger;
        Suspension = ZSuspensionTypes.Full;
        Color = ZBicyclePaintColors.Black;
        Geometry = ZBicycleGeometries.Upright;
    }
}
