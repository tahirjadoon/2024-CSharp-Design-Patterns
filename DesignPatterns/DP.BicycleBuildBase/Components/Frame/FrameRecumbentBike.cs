using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Frame;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// this is actualy the same class as RecumbentBike class
/// not overwriting the original hence re-created as a component so that project 4, 5 and 6 do not break
/// </summary>
public class FrameRecumbentBike : AbstractBikeFrame
{
    public FrameRecumbentBike()
    {
        ModelName = ZBikeModelNames.BigBend;
        Suspension = ZSuspensionTypes.Front;
        Color = ZBicyclePaintColors.White;
        Geometry = ZBicycleGeometries.Recumbent;
    }
}
