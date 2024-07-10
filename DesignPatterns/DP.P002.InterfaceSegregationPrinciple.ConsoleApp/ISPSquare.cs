namespace DP.P002.InterfaceSegregationPrinciple.ConsoleApp;

public class ISPSquare : ITwoDimensionalShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea() => Width * Height;
}
