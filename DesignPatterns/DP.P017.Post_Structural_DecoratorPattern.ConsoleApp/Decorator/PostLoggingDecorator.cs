
using DP.Core;
using System.Diagnostics;

namespace DP.P017.Post_Structural_DecoratorPattern.ConsoleApp.Decorator;

public class PostLoggingDecorator : AbstractPostServiceDecorator
{
    public PostLoggingDecorator(IPostService postService) : base(postService)
    {
    }

    public async override Task<PostResponseModel?> GetPost(int postId)
    {
        ConsoleHelper.WriteLine($"\tPostLoggingDecorator.GetPost - Calling the API to get the post with ID: {postId}", ConsoleColor.Yellow);

        var stopWatch = Stopwatch.StartNew();

        try
        {
            var post = await base._postService.GetPost(postId);
            ConsoleHelper.WriteLine($"\tPostLoggingDecorator.GetPost - It took  {stopWatch.ElapsedMilliseconds} ms to call the API", ConsoleColor.Yellow);
            return post;
        }
        catch (Exception ex)
        {
            ConsoleHelper.WriteLine($"PostLoggingDecorator.GetPost - threw exception: {ex.Message}", ConsoleColor.Red);
            throw;
        }
        finally { stopWatch.Stop(); }
    }
}
