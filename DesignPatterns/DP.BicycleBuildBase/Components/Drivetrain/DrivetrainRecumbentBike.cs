using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class DrivetrainRecumbentBike : AbstractBikeDrivetrain
{
    public DrivetrainRecumbentBike()
    {
        Name = "Drivetrain3";
        Shifter = ZBicycleShifterTypes.Paddle;
        CrankLength = 8.13f;
        ChainLinkCount = 421;
        FrontCassetteCogs = 3;
        RearCassetteCogs = 7;
        IsEnclosed = false;
    }
}
