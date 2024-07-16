using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class DrivetrainMountainBike : AbstractBikeDrivetrain
{
    public DrivetrainMountainBike()
    {
        Name = "Drivetrain1";
        Shifter = ZBicycleShifterTypes.Trigger;
        CrankLength = 5.92f;
        ChainLinkCount = 126;
        FrontCassetteCogs = 2;
        RearCassetteCogs = 9;
        IsEnclosed = false;
    }
}
