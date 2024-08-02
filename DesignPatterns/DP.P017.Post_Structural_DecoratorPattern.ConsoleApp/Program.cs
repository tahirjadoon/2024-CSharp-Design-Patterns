// See https://aka.ms/new-console-template for more information
//https://www.csharptutorial.net/csharp-design-patterns/csharp-decorator-pattern/
using DP.Core;
using DP.P017.Post_Structural_DecoratorPattern.ConsoleApp;
using DP.P017.Post_Structural_DecoratorPattern.ConsoleApp.Decorator;

ConsoleHelper.TitleWrite("Post - Decorator Pattern implementation!");
ConsoleHelper.WriteEmptyLine();


ConsoleHelper.WriteLine("Using simple post case");
var postService = new PostService();
var post1 = await postService.GetPost(1);
ConsoleHelper.WriteLine($"\t{post1}", ConsoleColor.Cyan);

ConsoleHelper.DrawLine();

ConsoleHelper.WriteLine("Using PostLoggingDecorator");
IPostService postService1 = new PostService();
var postServiceLogging = new PostLoggingDecorator(postService1);
var post2 = await postServiceLogging.GetPost(2);
ConsoleHelper.WriteLine($"\t{post2}", ConsoleColor.Cyan);



