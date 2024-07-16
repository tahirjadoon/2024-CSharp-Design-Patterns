using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public interface IBikeDrivetrain
{
    public float CrankLength { get; set; }
    public int FrontCassetteCogs { get; set; }
    public int RearCassetteCogs { get; set; }
    public float ChainLinkCount { get; set; }
    public ZBicycleShifterTypes Shifter { get; set; }
    public bool IsEnclosed { get; set; }
}
