using DP.Core;

namespace DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp.Decorator;

public class BorrowableDecorator<T> : AbstractLibraryItemGenericDecorator<T>
{
    private readonly List<string> _borrowers = [];

    public BorrowableDecorator(AbstractGenericLibraryItem<T> _libraryItem) : base(_libraryItem)
    {
    }

    public void BorromItem(string name)
    {
        _borrowers.Add(name);
        base.NumCopies--;
    }

    public void ReturnItem(string name)
    {
        _borrowers.Remove(name);
        base.NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        _borrowers.ForEach(b => ConsoleHelper.WriteLine($"\t- Borrower: {b}", ConsoleColor.Green));
    }
}
