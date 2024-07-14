using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

/// <summary>
/// updated: 006-BikeBuild-FactoryMethodPattern
/// </summary>
public class CruiserBike : Bicycle
{
    public CruiserBike()
    {
        ModelName = ZBikeModelNames.GalvestonCruiser;
        Suspension = ZSuspensionTypes.Hardtail;
        Color = ZBicyclePaintColors.Red;
        Geometry = ZBicycleGeometries.Upright;
    }
}
