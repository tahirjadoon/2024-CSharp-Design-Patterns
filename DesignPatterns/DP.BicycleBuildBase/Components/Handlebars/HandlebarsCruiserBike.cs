namespace DP.BicycleBuildBase.Components.Handlebars;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public class HandlebarsCruiserBike : AbstractBikeHandlebars
{
    public HandlebarsCruiserBike()
    {
        // units are imperial   
        Length = 32.6f;
        Diameter = 1.0f;
        IsDropped = false;
        RiseAngle = 6.35f;
    }
}
