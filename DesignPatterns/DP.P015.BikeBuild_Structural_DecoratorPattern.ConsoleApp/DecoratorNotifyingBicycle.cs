using DP.BicycleBuildBase;

namespace DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

public class DecoratorNotifyingBicycle : AbstractBicycleDecorator
{
    private INotifier _notifier;

    public DecoratorNotifyingBicycle(IBicycle bicycle, INotifier notifier) : base(bicycle)
    {
        _notifier = notifier;
    }

    public override void Build()
    {
        base._undecoratedBicycle.Build();
        _notifier.Notify();
    }
}