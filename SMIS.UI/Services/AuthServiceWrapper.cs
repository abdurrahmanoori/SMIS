using SMIS.Infrastructure.Mobile.Services.Auth;
using SMIS.Infrastructure.Mobile.Services.Http;

namespace SMIS.UI.Services;

public class AuthServiceWrapper
{
    private readonly IAuthService _authService;

    public AuthServiceWrapper(IAuthService authService)
    {
        _authService = authService;
    }

    public Task<ApiResponse<LoginResponse>> LoginAsync(string userName, string password)
    {
        return _authService.LoginAsync(new LoginRequest 
        { 
            Email = userName, 
            Password = password 
        });
    }

    public Task LogoutAsync() => _authService.LogoutAsync();

    public Task<bool> IsAuthenticatedAsync() => _authService.IsAuthenticatedAsync();
}
