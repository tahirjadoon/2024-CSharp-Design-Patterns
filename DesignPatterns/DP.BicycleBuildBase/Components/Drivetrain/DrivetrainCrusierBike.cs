using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class DrivetrainCrusierBike : AbstractBikeDrivetrain
{
    public DrivetrainCrusierBike()
    {
        Name = "Drivetrain1";
        Shifter = ZBicycleShifterTypes.Twist;
        CrankLength = 6.72f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 1;
        RearCassetteCogs = 9;
        IsEnclosed = true;
    }
}
