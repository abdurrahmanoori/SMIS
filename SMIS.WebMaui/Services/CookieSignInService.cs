using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SMIS.UI.Shared.Services.Interfaces;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.WebMaui.Services;

/// <summary>
/// Blazor Server implementation of ISignInService.
/// Uses ASP.NET Identity SignInManager to establish and clear the cookie session.
/// </summary>
public class CookieSignInService : ISignInService
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CookieSignInService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task SignInAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        await _signInManager.SignInAsync(user!, isPersistent: false);
    }

    public async Task SignOutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    public Task<bool> IsAuthenticatedAsync()
    {
        return Task.FromResult(_httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated ?? false);
    }
}
