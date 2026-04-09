using Microsoft.AspNetCore.Components;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

public class DevelopmentAutoLoginService
{
    private readonly IUiAuthService _authService;
    private readonly NavigationManager _navigation;
    private const string DevUsername = "superadmin@smis.com";
    private const string DevPassword = "Pass123!";

    public DevelopmentAutoLoginService(IUiAuthService authService, NavigationManager navigation)
    {
        _authService = authService;
        _navigation = navigation;
    }

    public async Task<bool> TryAutoLoginAsync()
    {
#if DEBUG
        // Do not auto-login if the user explicitly navigated to /login (e.g. after logout)
        var path = new Uri(_navigation.Uri).AbsolutePath;
        if (path.Equals("/login", StringComparison.OrdinalIgnoreCase))
            return false;

        var isAuthenticated = await _authService.IsAuthenticatedAsync();
        if (!isAuthenticated)
        {
            var result = await _authService.LoginAsync(DevUsername, DevPassword);
            return result.Success ? true : throw new Exception("Auto login failed: user is not authenticated");
        }
        return isAuthenticated;
#else
        return await _authService.IsAuthenticatedAsync();
#endif
    }
}
