using DP.Core;

namespace DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

public class ActionMaterialInvNotifier : INotifier
{
    public void Notify()
    {
        ConsoleHelper.WriteLine("The materials inventory control system has been notified regarding the manufacture of this bicycle.", ConsoleColor.Yellow);
        ConsoleHelper.WriteEmptyLine();
    }
}
