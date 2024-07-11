using DP.BicycleBuildBase.Enums;
using DP.Core;
using DP.Core.Extensions;
using System.Numerics;

namespace DP.BicycleBuildBase;

public abstract class Bicycle
{
    protected Bicycle()
    {
        ModelName = string.Empty;
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ZManufacturingStatus.Specified;
    }

    protected string ModelName { get; init; }
    private int Year { get; set; }
    private string SerialNumber { get; }
    protected ZBicyclePaintColors Color { get; init; }
    protected ZBicycleGeometries Geometry { get; init; }
    protected ZSuspensionTypes Suspension { get; init; }
    private ZManufacturingStatus BuildStatus { get; set; }

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

        ConsoleHelper.WriteLine($"{Year} {ModelName} Bicycle serial number {SerialNumber} manufacturing complete!", ConsoleColor.Cyan);
        BuildStatus = ZManufacturingStatus.Complete;
        PrintBuildStatus();
    }

    private void PrintBuildStatus()
    {
        ConsoleHelper.WriteLine($"\tStatus: {BuildStatus.ToString()}");
    }

    public override string ToString()
    {
        return $"Your bicycle is a {Color.GetEnumDescription()} {ModelName}, with a {Suspension.GetEnumDescription()} suspension and a(n) {Geometry.GetEnumDescription()} geometry.";
    }
}
