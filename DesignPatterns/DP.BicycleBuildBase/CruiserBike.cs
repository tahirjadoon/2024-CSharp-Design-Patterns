using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

public class CruiserBike : Bicycle
{
    public CruiserBike()
    {
        ModelName = "Galveston Cruiser";
        Suspension = ZSuspensionTypes.Hardtail;
        Color = ZBicyclePaintColors.Red;
        Geometry = ZBicycleGeometries.Upright;
    }
}
