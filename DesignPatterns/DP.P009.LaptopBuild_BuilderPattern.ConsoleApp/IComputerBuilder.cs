namespace DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

/// <summary>
/// instead of interface we can also make this an absract class that concreate builders will use 
/// </summary>
public interface IComputerBuilder
{
    public void SetCPU();
    public void SetRAM();
    public void SetHardDrive();
    public void SetGraphicsCard() { } //optional
    public void SetSoundCard() { } //optional

    public IComputerProduct GetComputer();
}
