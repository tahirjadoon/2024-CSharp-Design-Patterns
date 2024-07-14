using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;

namespace DP.P006.BicycleBuild_FactoryMethodPattern.ConsoleApp;

public abstract class BicycleCreator
{
    public abstract IBicycle CreateProduct(ZBikeModelNames modelName);
}
