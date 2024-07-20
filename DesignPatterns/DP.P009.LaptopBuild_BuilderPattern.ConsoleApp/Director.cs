namespace DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

public class Director
{
    private IComputerBuilder _builder;

    public Director(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IComputerBuilder builder)
    {
        _builder = builder;
    }

    public IComputerProduct Make()
    {
        _builder.SetCPU();
        _builder.SetRAM();
        _builder.SetHardDrive();
        _builder.SetGraphicsCard();
        _builder.SetSoundCard();
        return _builder.GetComputer();
    }
}
