using DP.Core;

namespace DP.P003.DependencyInversionPrinciple.ConsoleApp;
public class DIPLamp
{
    public IToggleServer TheSwitch { get; set; }

    public DIPLamp(IToggleServer theSwitch)
    {
        TheSwitch = theSwitch;
    }

    public void ToggleLamp()
    {
        if (TheSwitch.ToggleOnOff())
            ConsoleHelper.WriteLine("The lamp is on", ConsoleColor.Green);
        else
            ConsoleHelper.WriteLine("The lamp is off", ConsoleColor.Red);
    }
}
