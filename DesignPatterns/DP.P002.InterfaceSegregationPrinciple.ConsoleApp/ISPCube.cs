namespace DP.P002.InterfaceSegregationPrinciple.ConsoleApp;

public class ISPCube : IThreeDimensionalShape
{
    public double Depth { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetVolume() => Width * Height * Depth;
}
