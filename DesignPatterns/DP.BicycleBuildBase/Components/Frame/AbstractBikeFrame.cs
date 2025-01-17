﻿using DP.BicycleBuildBase.Enums;
using DP.Core.Extensions;
using DP.Core;

namespace DP.BicycleBuildBase.Components.Frame;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// this is actualy the same class as Bicycle class
/// not overwriting the original hence re-created as a component so that project 4, 5 and 6 do not break
/// </summary>
public abstract class AbstractBikeFrame : IBikeFrame
{
    protected AbstractBikeFrame()
    {
        ModelName = ZBikeModelNames.Unknown;
        SerialNumber = Guid.NewGuid().ToString();
        Year = DateTime.Now.Year;
        BuildStatus = ZManufacturingStatus.Specified;
    }

    public ZBikeModelNames ModelName { get; init; }
    public int Year { get; set; }
    public string SerialNumber { get; }
    public ZBicyclePaintColors Color { get; init; }
    public ZBicycleGeometries Geometry { get; init; }
    public ZSuspensionTypes Suspension { get; init; }
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
