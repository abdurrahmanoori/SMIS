using SMIS.Application.Common.Response;

namespace SMIS.Infrastructure.Mobile.Services.Http;

public interface IApiClient
{
    Task<Result<TResponse>> GetAsync<TResponse>(string endpoint);
    Task<Result<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<Result<TResponse>> PutAsync<TRequest, TResponse>(string endpoint, TRequest data);
    Task<Result<bool>> DeleteAsync(string endpoint);
}
