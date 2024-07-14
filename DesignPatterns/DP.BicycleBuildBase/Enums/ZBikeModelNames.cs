using System.ComponentModel;

namespace DP.BicycleBuildBase.Enums;

/// <summary>
/// Created : 006-BikeBuild-FactoryMethodPattern
/// </summary>
public enum ZBikeModelNames
{
    Unknown,

    [Description("Hillcrest")]
    Hillcrest,

    [Description("Big Bend")]
    BigBend,

    [Description("Palo Duro Canyon Ranger")]
    PaloDuroCanyonRanger,

    [Description("Galveston Cruiser")]
    GalvestonCruiser
}
