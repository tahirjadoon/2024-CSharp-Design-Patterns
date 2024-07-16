using System.Globalization;

namespace DP.BicycleBuildBase.Components.Handlebars;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public abstract class AbstractBikeHandlebars : IBikeHandlebars
{
    public float Length { get; set; }
    public float Diameter { get; set; }
    public bool IsDropped { get; set; }
    public float RiseAngle { get; set; }

    public override string ToString()
    {
        var isDroppedText = "dropped";
        if (IsDropped) isDroppedText = "non-dropped";
        var result = $@"Your {isDroppedText} 
                                handlebars are {Length.ToString(CultureInfo.InvariantCulture)} wide, 
                                {Diameter.ToString(CultureInfo.InvariantCulture)} in diameter, 
                                with a rise angle of {RiseAngle.ToString(CultureInfo.InvariantCulture)}";
        return result;
    }
}
