using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.WebMaui.Services;

/// <summary>
/// Blazor Server implementation of ISignInService.
/// Uses ASP.NET Identity SignInManager to establish and clear the cookie session.
/// IsAuthenticatedAsync uses AuthenticationStateProvider because HttpContext is null
/// after the SignalR circuit starts.
/// </summary>
public class CookieSignInService : ISignInService
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly AuthenticationStateProvider _authStateProvider;

    public CookieSignInService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, AuthenticationStateProvider authStateProvider)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _authStateProvider = authStateProvider;
    }

    public async Task SignInAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        await _signInManager.SignInAsync(user!, isPersistent: true);
    }

    public async Task SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public async Task<bool> IsAuthenticatedAsync()
    {
        var state = await _authStateProvider.GetAuthenticationStateAsync();
        return state.User.Identity?.IsAuthenticated ?? false;
    }
}
