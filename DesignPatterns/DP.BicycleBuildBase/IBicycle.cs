using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase;

/// <summary>
/// Added via 006-BikeBuild-FactoryMethodPattern
/// </summary>
public interface IBicycle
{
    public ZBikeModelNames ModelName { get; set; }
    public int Year { get; }
    public string SerialNumber { get; }
    public ZBicyclePaintColors Color { get; set; }
    public ZBicycleGeometries Geometry { get; set; }
    public ZSuspensionTypes Suspension { get; set; }
    public ZManufacturingStatus BuildStatus { get; set; }

    void Build();
}
