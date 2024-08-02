// See https://aka.ms/new-console-template for more information
//https://dofactory.com/net/decorator-design-pattern
using DP.Core;
using DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp;
using DP.P019.LibraryOptmzd_Structural_DecoratorPattern.ConsoleApp.Decorator;

ConsoleHelper.TitleWrite("Library Opimized - Decorator Pattern implementation!");
ConsoleHelper.WriteEmptyLine();

ConsoleHelper.WriteLine("Simple Book");
var book = new Book("Don Quixote", "Miguel de Cervantes", 20);
book.Display();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("Simple Video");
var video = new Video("Steven Spielberg", "Schindler's List", 120, 19);
video.Display();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("Borrowble Book");
var bBook = new BorrowableDecorator<Book>(book);
bBook.Display();
bBook.BorromItem("Lorry");
bBook.BorromItem("Abby");
bBook.Display();
bBook.ReturnItem("Lorry");
bBook.Display();

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("Borrowble Video");
var bVideo = new BorrowableDecorator<Video>(video);
bVideo.Display();
bVideo.BorromItem("Jack");
bVideo.BorromItem("Mich");
bVideo.Display();
bVideo.ReturnItem("Jack");
bVideo.Display();