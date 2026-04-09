using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using SMIS.Application.Common.Response;

namespace SMIS.Infrastructure.Mobile.Services.Http;

public class ApiClient : IApiClient
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };
    }

    public async Task<Result<TResponse>> GetAsync<TResponse>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<Result<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var response = await _httpClient.PostAsJsonAsync(endpoint, data);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<Result<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var response = await _httpClient.PutAsJsonAsync(endpoint, data);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<Result<bool>> DeleteAsync(string endpoint)
    {
        var response = await _httpClient.DeleteAsync(endpoint);
        return response.IsSuccessStatusCode
            ? Result<bool>.SuccessResult(true)
            : await HandleResponseAsync<bool>(response);
    }

    private async Task<Result<T>> HandleResponseAsync<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            if (string.IsNullOrWhiteSpace(content))
                return Result<T>.SuccessResult(default);

            var direct = JsonSerializer.Deserialize<T>(content, _jsonOptions);
            return Result<T>.SuccessResult(direct);
        }

        if (!string.IsNullOrWhiteSpace(content))
        {
            try
            {
                var errorResult = JsonSerializer.Deserialize<Result<T>>(content, _jsonOptions);
                if (errorResult != null) return errorResult;
            }
            catch { }
        }

        return response.StatusCode switch
        {
            HttpStatusCode.Unauthorized => Result<T>.FailureResult("Unauthorized", "Please login again."),
            HttpStatusCode.Forbidden => Result<T>.FailureResult("Forbidden", "Access denied."),
            HttpStatusCode.NotFound => Result<T>.FailureResult("NotFound", "Resource not found."),
            _ => Result<T>.FailureResult("Error", $"Request failed: {response.StatusCode}")
        };
    }
}

