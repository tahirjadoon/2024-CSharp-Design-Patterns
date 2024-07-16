namespace DP.BicycleBuildBase.Components.Handlebars;

/// <summary>
/// Created: 007-BikeBuild-AbstractFactoryPattern
/// </summary>
public interface IBikeHandlebars
{
    public float Length { get; set; }
    public float Diameter { get; set; }
    public bool IsDropped { get; set; }
    public float RiseAngle { get; set; }
}
