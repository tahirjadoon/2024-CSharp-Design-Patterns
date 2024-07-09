namespace DP.P001.OpenClosePrinciple.ConsoleApp;

public class OCPSquare : IShapeWithArea
{
    public OCPSquare(double lengthOfSide)
    {
        Area = lengthOfSide * lengthOfSide;
    }

    public double Area { get; }
}