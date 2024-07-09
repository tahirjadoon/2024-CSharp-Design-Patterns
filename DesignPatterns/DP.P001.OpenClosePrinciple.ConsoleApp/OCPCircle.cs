namespace DP.P001.OpenClosePrinciple.ConsoleApp;

public class OCPCircle : IShapeWithArea
{
    public OCPCircle(double radius)
    {
        Area = Math.PI * (radius * radius);
    }

    public double Area { get; }
}

