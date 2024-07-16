using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class DrivetrainRoadBike : AbstractBikeDrivetrain
{
    public DrivetrainRoadBike()
    {
        Name = "Drivetrain3";
        Shifter = ZBicycleShifterTypes.Paddle;
        CrankLength = 6.72f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 3;
        RearCassetteCogs = 8;
        IsEnclosed = false;
    }
}
