namespace DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp.Decorator;

public abstract class AbstractLibraryItemGenericDecorator<T>(AbstractGenericLibraryItem<T> _libraryItem) : AbstractGenericLibraryItem<T>
{
    public override void Display() => _libraryItem.Display();
}
