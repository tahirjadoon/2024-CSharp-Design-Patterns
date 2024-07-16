namespace DP.BicycleBuildBase.Components.Handlebars;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class HandlebarsMountianBike : AbstractBikeHandlebars
{
    public HandlebarsMountianBike()
    {
        // units are imperial   
        Length = 24.5f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 0.0f;
    }
}
