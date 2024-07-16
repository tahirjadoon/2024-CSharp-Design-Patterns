using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Brakes;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public interface IBikeBrakes
{
    public ZBicycleBrakeTypes BrakeType { get; set; }
}
