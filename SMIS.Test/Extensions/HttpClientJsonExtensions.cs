using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SMIS.Test.Extensions;

public static class HttpClientJsonExtensions
{
    private static readonly JsonSerializerOptions DefaultJsonOptions = CreateJsonOptions();

    public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value) =>
        client.PostAsJsonAsync(requestUri, value, DefaultJsonOptions);

    public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value) =>
        client.PutAsJsonAsync(requestUri, value, DefaultJsonOptions);

    public static Task<T?> ReadFromJsonAsync<T>(this HttpContent content) =>
        content.ReadFromJsonAsync<T>(DefaultJsonOptions);

    private static JsonSerializerOptions CreateJsonOptions() => new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
    };
}