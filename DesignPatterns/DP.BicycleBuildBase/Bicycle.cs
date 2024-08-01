using DP.BicycleBuildBase.Enums;
using DP.Core;
using DP.Core.Extensions;
using System.Numerics;

namespace DP.BicycleBuildBase;

/// <summary>
/// Updated via 006-BikeBuild-FactoryMethodPattern, interface implemented and access modifiers updates
/// 
/// </summary>
public abstract class Bicycle : IBicycle
{
    protected Bicycle()
    {
        ModelName = ZBikeModelNames.Unknown;
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ZManufacturingStatus.Specified;
    }

    public ZBikeModelNames ModelName { get; set; }
    public int Year { get; set; }
    public string SerialNumber { get; }
    public ZBicyclePaintColors Color { get; set; }
    public ZBicycleGeometries Geometry { get; set; }
    public ZSuspensionTypes Suspension { get; set; }
    public ZManufacturingStatus BuildStatus { get; set; }

    public void Build()
    {
        ConsoleHelper.WriteLine($"Manufacturing a {Geometry.ToString()} frame...", ConsoleColor.Cyan);
        BuildStatus = ZManufacturingStatus.FrameManufactured;
        PrintBuildStatus();

        ConsoleHelper.WriteLine($"Painting the frame {Color.ToString()}", ConsoleColor.Cyan);
        BuildStatus = ZManufacturingStatus.Painted;
        PrintBuildStatus();

        if (Suspension != ZSuspensionTypes.Hardtail)
        {
            ConsoleHelper.WriteLine($"Mounting the {Suspension.ToString()} suspension.", ConsoleColor.Cyan);
            BuildStatus = ZManufacturingStatus.SuspensionMounted;
            PrintBuildStatus();
        }

        ConsoleHelper.WriteLine($"{Year} {ModelName.GetEnumDescription()} Bicycle serial number {SerialNumber} manufacturing complete!", ConsoleColor.Cyan);
        BuildStatus = ZManufacturingStatus.Complete;
        PrintBuildStatus();
    }

    private void PrintBuildStatus()
    {
        ConsoleHelper.WriteLine($"\tStatus: {BuildStatus.ToString()}");
    }

    public override string ToString()
    {
        return $"Your bicycle is a {Color.GetEnumDescription()} {ModelName.GetEnumDescription()}, with a {Suspension.GetEnumDescription()} suspension and a(n) {Geometry.GetEnumDescription()} geometry.";
    }
}
