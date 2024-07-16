using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Frame;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// this is actualy the same class as IBicycle
/// not overwriting the original hence re-created as a component so that project 4, 5 and 6 do not break
/// </summary>
public interface IBikeFrame
{
    public ZBikeModelNames ModelName { get; init; }
    public int Year { get; set; }
    public string SerialNumber { get; }
    public ZBicyclePaintColors Color { get; init; }
    public ZBicycleGeometries Geometry { get; init; }
    public ZSuspensionTypes Suspension { get; init; }
    public ZManufacturingStatus BuildStatus { get; set; }

    void Build();
}
