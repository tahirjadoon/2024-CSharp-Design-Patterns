using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Seats;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SeatRecumbentBike : AbstractBikeSeat
{
    public SeatRecumbentBike()
    {
        SaddleType = ZBicycleSeatSaddleTypes.LazyBoyRecliner;
        SpringCount = 6;
        PaddingThickness = 0.5f;
    }
}
