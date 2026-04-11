using Microsoft.AspNetCore.Components.Authorization;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.WebMaui.Services;

/// <summary>
/// Blazor Server implementation of ICurrentUser.
/// Uses AuthenticationStateProvider instead of IHttpContextAccessor
/// because HttpContext is null after the SignalR circuit is established.
/// </summary>
public class BlazorCurrentUser : ICurrentUser
{
    private readonly AuthenticationStateProvider _authStateProvider;

    public BlazorCurrentUser(AuthenticationStateProvider authStateProvider)
    {
        _authStateProvider = authStateProvider;
    }

    private async Task<ClaimsPrincipal> GetUserAsync()
    {
        var state = await _authStateProvider.GetAuthenticationStateAsync();
        return state.User;
    }

    public string GetId()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "1";
    }

    public string GetShopId()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.FindFirst(nameof(ApplicationUser.ShopId))?.Value ?? string.Empty;
    }

    public string GetLangId()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.FindFirst(nameof(ApplicationUser.LanguageId))?.Value ?? "1";
    }

    public bool IsRetailAdmin()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.IsInRole(SD.Role_RShop_Admin);
    }

    public bool IsWholesaleAdmin()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.IsInRole(SD.Role_WShop_Admin);
    }

    public bool IsSuperAdmin()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.IsInRole(SD.Role_Super_Admin);
    }

    public List<string> Roles()
    {
        var user = GetUserAsync().GetAwaiter().GetResult();
        return user.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();
    }
}
