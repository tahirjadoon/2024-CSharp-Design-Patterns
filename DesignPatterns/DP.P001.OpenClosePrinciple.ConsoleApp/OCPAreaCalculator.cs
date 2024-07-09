namespace DP.P001.OpenClosePrinciple.ConsoleApp;

public class OCPAreaCalculator
{
    private double _area { get; set; }
    public double Area => _area;

    public void AddShape(IShapeWithArea shape)
    {
        _area += shape.Area;
    }

}
