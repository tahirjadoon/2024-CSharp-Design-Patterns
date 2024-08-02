using DP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp;

public class Book : AbstractGenericLibraryItem<Book>
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
