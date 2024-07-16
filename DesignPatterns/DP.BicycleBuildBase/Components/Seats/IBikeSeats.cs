using DP.BicycleBuildBase.Enums;

namespace DP.BicycleBuildBase.Components.Seats;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public interface IBikeSeats
{
    public ZBicycleSeatSaddleTypes SaddleType { get; set; }
    public float PaddingThickness { get; set; }
    public int SpringCount { get; set; }
}
