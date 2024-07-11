// See https://aka.ms/new-console-template for more information
using DP.BicycleBuildBase;
using DP.BicycleBuildBase.Enums;
using DP.Core;
using DP.Core.Extensions;

ConsoleHelper.TitleWrite("No pattern implementation!");

const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike";

if(args.Length <= 0)
{
    ConsoleHelper.ErrorWrite(errorText);
}
else
{
    var arg = args[0].Trim();
    var bicycleType = arg.ToLower().ToEnumNullable<ZBikeTypes>();

    Bicycle? bikeToBuild;
    bikeToBuild = bicycleType switch
    {
        ZBikeTypes.Mountainbike => new MountainBike(),
        ZBikeTypes.Roadbike => new RoadBike(),
        ZBikeTypes.Recumbent => new RecumbentBike(),
        ZBikeTypes.Cruiser => new CruiserBike(),
        _ => null
    };

    if (bikeToBuild == null)
    {
        ConsoleHelper.ErrorWrite(errorText);
        throw new Exception($"Unknown bicycle type: {arg}");
    }
    else
    {
        bikeToBuild.Build();
        ConsoleHelper.WriteEmptyLine();
        ConsoleHelper.SuccessWrite(bikeToBuild.ToString());
    }

}