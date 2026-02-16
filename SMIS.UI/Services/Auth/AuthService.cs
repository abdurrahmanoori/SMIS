using SMIS.UI.Models;
using SMIS.UI.Services.Base;
using SMIS.UI.Services.Http;

namespace SMIS.UI.Services.Auth;

public interface IAuthService
{
    Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequest request);
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}

public class AuthService : BaseService, IAuthService
{
    private readonly IApiClient _apiClient;
    private readonly ITokenStorage _tokenStorage;

    public AuthService(IApiClient apiClient, ITokenStorage tokenStorage)
    {
        _apiClient = apiClient;
        _tokenStorage = tokenStorage;
    }

    public async Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequest request)
    {
        var response = await _apiClient.PostAsync<LoginRequest, LoginResponse>("/api/auth/login", request);
        
        if (response.Success && response.Response?.Token != null)
        {
            await _tokenStorage.SetTokenAsync(response.Response.Token);
        }
        
        return response;
    }

    public async Task LogoutAsync()
    {
        await _tokenStorage.ClearTokenAsync();
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var token = await _tokenStorage.GetTokenAsync();
        return !string.IsNullOrEmpty(token);
    }
}
