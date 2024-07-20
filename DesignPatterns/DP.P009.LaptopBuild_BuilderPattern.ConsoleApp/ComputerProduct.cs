using DP.Core;

namespace DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

/// <summary>
/// Product to build - components
/// The components can come from their own base library just like the Bicycle project
/// </summary>
public class ComputerProduct : IComputerProduct
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string HardDrive { get; set; }
    public string GraphicsCard { get; set; }
    public string SoundCard { get; set; }

    public void DisplaySpecifications()
    {
        ConsoleHelper.WriteLine($"CPU: {CPU}");
        ConsoleHelper.WriteLine($"RAM: {RAM}");
        ConsoleHelper.WriteLine($"Hard Drive: {HardDrive}");
        ConsoleHelper.WriteLine($"Graphics Card: {GraphicsCard ?? "Not present"}");
        ConsoleHelper.WriteLine($"Sound Card: {SoundCard ?? "Not present"}");
    }
}
