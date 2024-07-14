using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

/// <summary>
/// Added via 006-BikeBuild-FactoryMethodPattern
/// </summary>
public interface IBicycle
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
