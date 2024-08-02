namespace DP.P017.Post_Structural_DecoratorPattern.ConsoleApp;

public class PostResponseModel
{
    /// <summary>
    /// add the postId to tthe the end of this url and path parameter
    /// </summary>
    public const string PostBaseUrl = "https://jsonplaceholder.typicode.com/posts/";

    /*
    Return response is like
    {
        "userId": 1,
        "id": 1,
        "title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
        "body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
    }
    */

    public int UserId { get; set; }
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }

    public override string ToString() => $"Post => [Id={Id}, UserId={UserId}, Title={Title}]";
}
