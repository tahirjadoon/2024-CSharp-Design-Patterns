using System.Text.Json;

namespace DP.Core.Extensions;

public static class ObjectExtensions
{
    public static string ToJson<T>(this T obj) //where T : class
    {
        if (obj == null) return string.Empty;
        var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        var jsonString = JsonSerializer.Serialize(obj, options);
        return jsonString;
    }

    public static T FromJson<T>(this string json)
    {
        if (string.IsNullOrWhiteSpace(json)) return default(T);
        var obj = JsonSerializer.Deserialize<T>(json);
        return obj;
    }
}
