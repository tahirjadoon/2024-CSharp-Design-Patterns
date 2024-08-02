namespace DP.P017.Post_Structural_DecoratorPattern.ConsoleApp;

public interface IPostService
{
    Task<PostResponseModel?> GetPost(int postId);
}
