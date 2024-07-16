using DP.BicycleBuildBase.Enums;
using DP.Core.Extensions;
using System.Globalization;

namespace DP.BicycleBuildBase.Components.Seats;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public abstract class AbstractBikeSeat : IBikeSeats
{
    public ZBicycleSeatSaddleTypes SaddleType { get; set; }
    public float PaddingThickness { get; set; }
    public int SpringCount { get; set; }

    public override string ToString()
    {
        return
            @$"Your seat has a 
                        {SaddleType.GetEnumDescription()} type saddle 
                        with a padding thickness of {PaddingThickness.ToString(CultureInfo.InvariantCulture)}, 
                        and {SpringCount.ToString(CultureInfo.InvariantCulture)} springs";
    }
}
