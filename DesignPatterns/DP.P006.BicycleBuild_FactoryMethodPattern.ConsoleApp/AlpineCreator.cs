using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;

namespace DP.P006.BicycleBuild_FactoryMethodPattern.ConsoleApp;

public class AlpineCreator : BicycleCreator
{
    public override IBicycle CreateProduct(ZBikeModelNames modelName)
    {
        IBicycle bicycleToBuild = modelName switch
        {
            ZBikeModelNames.PaloDuroCanyonRanger => new MountainBike(),
            ZBikeModelNames.GalvestonCruiser => new CruiserBike(),
            _ => throw new Exception("Invalid bicycle model")
        };
        return bicycleToBuild;
    }
}
