using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;

namespace DP.P006.BicycleBuild_FactoryMethodPattern.ConsoleApp;

public class DallasCreator : BicycleCreator
{
    public override IBicycle CreateProduct(ZBikeModelNames modelName)
    {
        IBicycle bicycleToBuild = modelName switch
        {
            ZBikeModelNames.Hillcrest => new RoadBike(),
            ZBikeModelNames.BigBend => new RecumbentBike(),
            _ => throw new Exception("Invalid bicycle model")
        };
        return bicycleToBuild;
    }
}
