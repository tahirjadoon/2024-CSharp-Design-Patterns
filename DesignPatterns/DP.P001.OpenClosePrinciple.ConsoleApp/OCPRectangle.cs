namespace DP.P001.OpenClosePrinciple.ConsoleApp;

public class OCPRectangle : IShapeWithArea
{
    public OCPRectangle(double width, double height)
    {
        Area = width * height;
    }

    public double Area { get; }
}
