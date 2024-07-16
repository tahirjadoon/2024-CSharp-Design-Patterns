namespace DP.BicycleBuildBase.Components.Handlebars;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class HandlebarsRecumbentBike : AbstractBikeHandlebars
{
    public HandlebarsRecumbentBike()
    {
        // units are imperial   
        Length = 11.5f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 2.5f;
    }
}
