using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Seats;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class SeatGeneric : AbstractBikeSeat
{
    public SeatGeneric()
    {
        PaddingThickness = 0.1f;
        SaddleType = ZBicycleSeatSaddleTypes.ModeratelyWaved;
        SpringCount = 0;
    }
}
