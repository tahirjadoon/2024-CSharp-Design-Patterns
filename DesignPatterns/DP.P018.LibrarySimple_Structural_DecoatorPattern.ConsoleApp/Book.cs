using DP.Core;

namespace DP.P018.LibrarySimple_Structural_DecoatorPattern.ConsoleApp;

public class Book : AbstractLibraryItem
{
    private string _author;
    private string _title;

    public Book(string author, string title, int numCopies)
    {
        _author = author;
        _title = title;
        base.NumCopies = numCopies;
    }

    public override void Display()
    {
        ConsoleHelper.WriteLine($"\tBook => [Author={_author}, Title={_title}], Copies={base.NumCopies}]", ConsoleColor.Yellow);
    }
}
