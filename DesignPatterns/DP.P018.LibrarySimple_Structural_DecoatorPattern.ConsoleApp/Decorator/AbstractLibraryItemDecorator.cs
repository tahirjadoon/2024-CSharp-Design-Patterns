namespace DP.P018.LibrarySimple_Structural_DecoatorPattern.ConsoleApp.Decorator;

public abstract class AbstractLibraryItemDecorator : AbstractLibraryItem
{
    protected AbstractLibraryItem _libraryItem;

    protected AbstractLibraryItemDecorator(AbstractLibraryItem libraryItem)
    {
        _libraryItem = libraryItem;
    }

    public override void Display()
    {
        _libraryItem.Display();
    }
}
