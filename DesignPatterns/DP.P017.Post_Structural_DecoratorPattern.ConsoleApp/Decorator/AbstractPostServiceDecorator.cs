namespace DP.P017.Post_Structural_DecoratorPattern.ConsoleApp.Decorator;

public abstract class AbstractPostServiceDecorator : IPostService
{
    protected readonly IPostService _postService;

    protected AbstractPostServiceDecorator(IPostService postService)
    {
        _postService = postService;
    }

    public abstract Task<PostResponseModel?> GetPost(int postId);
}
