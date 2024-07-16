using DP.BicycleBuildBase.Enums;
using DP.Core.Extensions;
using System.Globalization;

namespace DP.BicycleBuildBase.Components.Brakes;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public abstract class AbstractBikeBrakes : IBikeBrakes
{
    public ZBicycleBrakeTypes BrakeType { get; set; }

    public override string ToString()
    {
        return $"Your brakes are {BrakeType.GetEnumDescription()}";
    }
}
