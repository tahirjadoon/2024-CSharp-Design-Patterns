using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Seats;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SeatCrusierBike : AbstractBikeSeat
{
    public SeatCrusierBike()
    {
        PaddingThickness = 0.4f; // very cushy!
        SaddleType = ZBicycleSeatSaddleTypes.Curved;
        SpringCount = 3;
    }
}
