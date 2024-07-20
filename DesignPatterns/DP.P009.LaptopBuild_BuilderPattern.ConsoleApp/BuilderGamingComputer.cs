using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P009.LaptopBuild_BuilderPattern.ConsoleApp;

public class BuilderGamingComputer : IComputerBuilder
{
    private readonly ComputerProduct _computer;

    public BuilderGamingComputer()
    {
        _computer = new ComputerProduct();
    }

    public IComputerProduct GetComputer()
    {
        return _computer;
    }

    public void SetCPU()
    {
        _computer.CPU = "High Performance CPU";
    }

    public void SetHardDrive()
    {
        _computer.HardDrive = "1 TB SSD";
    }

    public void SetRAM()
    {
        _computer.RAM = "16 GB DDR4";
    }

    public void SetGraphicsCard()
    {
        _computer.GraphicsCard = "High-end Graphics Card";
    }

    public void SetSoundCard()
    {
        _computer.SoundCard = "7.1 Surround Sound Card";
    }
}
