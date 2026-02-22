namespace SMIS.Infrastructure.Mobile.Services.Http;

public interface IApiClient
{
    Task<ApiResponse<TResponse>> GetAsync<TResponse>(string endpoint);
    Task<ApiResponse<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<ApiResponse<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<ApiResponse<bool>> DeleteAsync(string endpoint);
}

public class ApiResponse<T>
{
    public T? Response { get; set; }
    public bool Success { get; set; }
    public string? Message { get; set; }
    public List<ValidationError>? Errors { get; set; }
}

public class ValidationError
{
    public string? Code { get; set; }
    public string? Description { get; set; }
}
