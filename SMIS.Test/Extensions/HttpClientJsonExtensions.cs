using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SMIS.Test.Extensions
{
    public static class HttpClientJsonExtensions
    {
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        public static Task<HttpResponseMessage> PostAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
        {
            return client.PostAsJsonAsync(requestUri, value, JsonOptions);
        }

        public static Task<HttpResponseMessage> PutAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
        {
            return client.PutAsJsonAsync(requestUri, value, JsonOptions);
        }

        public static Task<T?> ReadFromJsonAsync<T>(this HttpContent content)
        {
            return content.ReadFromJsonAsync<T>(JsonOptions);
        }
    }
}