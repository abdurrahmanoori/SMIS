using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using SMIS.UI.Models;

namespace SMIS.UI.Services.Http;

public interface IApiClient
{
    Task<ApiResponse<TResponse>> GetAsync<TResponse>(string endpoint);
    Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<ApiResponse<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<ApiResponse<bool>> DeleteAsync(string endpoint);
}

public class ApiClient : IApiClient
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<ApiResponse<TResponse>> GetAsync<TResponse>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var response = await _httpClient.PostAsJsonAsync(endpoint, data);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<ApiResponse<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
    {
        var response = await _httpClient.PutAsJsonAsync(endpoint, data);
        return await HandleResponseAsync<TResponse>(response);
    }

    public async Task<ApiResponse<bool>> DeleteAsync(string endpoint)
    {
        var response = await _httpClient.DeleteAsync(endpoint);
        return response.IsSuccessStatusCode
            ? new ApiResponse<bool> { Success = true, Response = true }
            : await HandleResponseAsync<bool>(response);
    }

    private async Task<ApiResponse<T>> HandleResponseAsync<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return new ApiResponse<T> { Success = true, Response = default };
            }

            try
            {
                // Try to deserialize as Result<T> wrapper first
                var resultWrapper = JsonSerializer.Deserialize<ApiResponse<T>>(content, _jsonOptions);
                if (resultWrapper != null && resultWrapper.Response != null)
                {
                    return resultWrapper;
                }
                
                // If no wrapper, deserialize directly as T
                var directResult = JsonSerializer.Deserialize<T>(content, _jsonOptions);
                return new ApiResponse<T> { Success = true, Response = directResult };
            }
            catch (JsonException)
            {
                return new ApiResponse<T> { Success = true, Response = default };
            }
        }

        if (string.IsNullOrWhiteSpace(content))
        {
            return CreateError<T>("Error", $"Request failed: {response.StatusCode}");
        }

        try
        {
            var errorResult = JsonSerializer.Deserialize<ApiResponse<T>>(content, _jsonOptions);
            if (errorResult != null) return errorResult;
        }
        catch { }

        return response.StatusCode switch
        {
            HttpStatusCode.Unauthorized => CreateError<T>("Unauthorized", "Please login again."),
            HttpStatusCode.Forbidden => CreateError<T>("Forbidden", "Access denied."),
            HttpStatusCode.NotFound => CreateError<T>("NotFound", "Resource not found."),
            _ => CreateError<T>("Error", $"Request failed: {response.StatusCode}")
        };
    }

    private static ApiResponse<T> CreateError<T>(string code, string description)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Errors = new List<ValidationError> { new() { Code = code, Description = description } }
        };
    }
}
