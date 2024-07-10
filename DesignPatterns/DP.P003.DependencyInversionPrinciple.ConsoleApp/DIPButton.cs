namespace DP.P003.DependencyInversionPrinciple.ConsoleApp;

public class DIPButton : IToggleServer
{
    private bool _enabled = false;
    public bool Enabled => _enabled;

    public bool ToggleOnOff()
    {
        _enabled = !_enabled;
        return _enabled;
    }
}

