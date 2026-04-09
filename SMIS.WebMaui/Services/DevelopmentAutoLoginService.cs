using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

public class DevelopmentAutoLoginService
{
    private readonly IUiAuthService _authService;

    public DevelopmentAutoLoginService(IUiAuthService authService)
    {
        _authService = authService;
    }

    // Login and logout must happen via real HTTP endpoints (/account/login, /logout)
    // because SignInManager requires a real HTTP request/response cycle to write cookies.
    // Auto-login from within the Blazor circuit is not possible for the same reason.
    public Task<bool> TryAutoLoginAsync() => _authService.IsAuthenticatedAsync();
}
