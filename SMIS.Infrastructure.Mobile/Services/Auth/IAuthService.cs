using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SMIS.Infrastructure.Mobile.Services.Auth;

public interface IAuthService
{
    Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequest request);
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}

public class AuthService : IAuthService
{
    private readonly IApiClient _apiClient;
    private readonly ITokenStorage _tokenStorage;
    private readonly IMobileCurrentUser _currentUser;

    public AuthService(IApiClient apiClient, ITokenStorage tokenStorage, IMobileCurrentUser currentUser)
    {
        _apiClient = apiClient;
        _tokenStorage = tokenStorage;
        _currentUser = currentUser;
    }

    public async Task<ApiResponse<LoginResponse>> LoginAsync(LoginRequest request)
    {
        var response = await _apiClient.PostAsync<LoginRequest, LoginResponse>("/api/auth/login", request);
        
        if (response.Success && response.Response?.Token != null)
        {
            await _tokenStorage.SetTokenAsync(response.Response.Token);
            
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

public class LoginRequest
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
}

public class LoginResponse
{
    public string? Token { get; set; }
    public string? UserId { get; set; }
    public string? UserName { get; set; }
}
