using DP.BicycleBuildBase.Enums;
using DP.Core.Extensions;
using System.Globalization;

namespace DP.BicycleBuildBase.Components.Drivetrain;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public abstract class AbstractBikeDrivetrain : IBikeDrivetrain
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Cost { get; set; }
    public float CrankLength { get; set; }
    public int FrontCassetteCogs { get; set; }
    public int RearCassetteCogs { get; set; }
    public float ChainLinkCount { get; set; }
    public ZBicycleShifterTypes Shifter { get; set; }
    public bool IsEnclosed { get; set; }

    protected AbstractBikeDrivetrain()
    {
        Name = "Unnamed Component";
    }
    public override string ToString()
    {
        return
            @$"Your drivetrain consists of a 
                            {CrankLength.ToString(CultureInfo.InvariantCulture)} inch crank, 
                            {FrontCassetteCogs.ToString(CultureInfo.InvariantCulture)} cost in the front cassette, 
                            {RearCassetteCogs.ToString(CultureInfo.InvariantCulture)} cogs in the rear cassette, 
                            and a chain with {ChainLinkCount.ToString(CultureInfo.InvariantCulture)} links in the chain 
                            and a {Shifter.GetEnumDescription()} type shifter";
    }
}
