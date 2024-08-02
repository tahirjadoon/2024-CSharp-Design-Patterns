using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DP.P017.Post_Structural_DecoratorPattern.ConsoleApp;

public class PostService : IPostService
{
    private readonly HttpClient _httpClient;

    public PostService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<PostResponseModel?> GetPost(int postId)
    {
        var url = $"{PostResponseModel.PostBaseUrl}{postId}";
        var response = await _httpClient.GetAsync(url);
        if(!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
        }

        var responseContent = await response.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<PostResponseModel?>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return result;
    }
}
