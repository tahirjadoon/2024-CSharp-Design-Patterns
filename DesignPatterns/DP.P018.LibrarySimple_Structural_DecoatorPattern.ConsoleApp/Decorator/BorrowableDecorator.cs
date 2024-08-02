using DP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P018.LibrarySimple_Structural_DecoatorPattern.ConsoleApp.Decorator;

public class BorrowableDecorator : AbstractLibraryItemDecorator
{
    protected readonly List<string> _borrowers = new List<string>();

    public BorrowableDecorator(AbstractLibraryItem libraryItem) : base(libraryItem)
    {
    }

    public void BorromItem(string name)
    {
        _borrowers.Add(name);
        base._libraryItem.NumCopies--;
    }

    public void ReturnItem(string name)
    {
        _borrowers.Remove(name);
        base._libraryItem.NumCopies++;
    }

    public override void Display()
    {
        base.Display();
        foreach (var item in _borrowers)
        {
            ConsoleHelper.WriteLine($"\t- Borrower: {item}", ConsoleColor.Green);
        }
    }
}
