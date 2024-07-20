using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

public class BuilderBasicComputer : IComputerBuilder
{
    private readonly ComputerProduct _computer;

    public BuilderBasicComputer()
    {
        _computer = new ComputerProduct();
    }

    public IComputerProduct GetComputer()
    {
        return _computer;
    }

    public void SetCPU()
    {
        _computer.CPU = "I5 CPU";
    }

    public void SetHardDrive()
    {
        _computer.HardDrive = "256 GB SSD";
    }

    public void SetRAM()
    {
        _computer.RAM = "8 GB DDR4";
    }

    public void SetGraphicsCard()
    {
        _computer.GraphicsCard = "Low-end Graphics Card";
    }

    public void SetSoundCard()
    {
        _computer.SoundCard = "5.1 Surround Sound Card";
    }
}
