using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;
using DP.Core.Extensions;

namespace DP.P005.BicycleBuild_SimpleFactoryPattern.ConsoleApp;

public class SimpleBicycleFactory
{
    public Bicycle Create(string argBicycleType)
    {
        var bicycleType = argBicycleType.ToLower().ToEnumNullable<ZBikeTypes>();

        Bicycle bikeToBuild;
        switch (bicycleType)
        {
            case ZBikeTypes.Mountainbike:
                bikeToBuild = new MountainBike(); break;
            case ZBikeTypes.Cruiser:
                bikeToBuild = new CruiserBike(); break;
            case ZBikeTypes.Recumbent:
                bikeToBuild = new RecumbentBike(); break;
            case ZBikeTypes.Roadbike:
                bikeToBuild = new RoadBike(); break;
            default:
                throw new Exception($"Unknown bicycle type: {argBicycleType}");
        }
        return bikeToBuild;
    }
}
