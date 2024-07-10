namespace DP.P002.InterfaceSegregationPrinciple.ConsoleApp;

public interface IThreeDimensionalShape : ITwoDimensionalShape
{
    public double Depth { get; set; }
}
