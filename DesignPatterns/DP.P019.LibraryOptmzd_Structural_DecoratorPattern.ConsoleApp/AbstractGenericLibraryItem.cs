namespace DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp;

public abstract class AbstractGenericLibraryItem<T>
{
    public int NumCopies { get; set; }

    public abstract void Display();
}
