using SMIS.Application.Identity.IServices;
using SMIS.UI.Models;
using SMIS.UI.Services.Base;
using SMIS.UI.Services.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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
    private readonly MauiCurrentUser _currentUser;

    public AuthService(IApiClient apiClient, ITokenStorage tokenStorage, ICurrentUser currentUser)
    {
        _apiClient = apiClient;
        _tokenStorage = tokenStorage;
        _currentUser = (MauiCurrentUser)currentUser;
    }

    public async Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequest request)
    {
        var response = await _apiClient.PostAsync<LoginRequest, LoginResponse>("/api/auth/login", request);
        
        if (response.Success && response.Response?.Token != null)
        {
            await _tokenStorage.SetTokenAsync(response.Response.Token);
            
            // Parse JWT token and set user claims
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(response.Response.Token);
            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(jwtToken.Claims, "jwt"));
            _currentUser.SetUser(claimsPrincipal);
        }
        
        return response;
    }

    public async Task LogoutAsync()
    {
        await _tokenStorage.ClearTokenAsync();
        _currentUser.ClearUser();
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var token = await _tokenStorage.GetTokenAsync();
        return !string.IsNullOrEmpty(token);
    }
}
