using Microsoft.AspNetCore.Http;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Infrastructure.Server.Services.Identity;

/// <summary>
/// Request-scoped access to identity claims embedded in the authenticated JWT.
/// ShopId is especially important because EF global query filters use it to enforce
/// tenant isolation for shop-owned entities.
/// </summary>
public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUser(
        IHttpContextAccessor httpContextAccessor
    )
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
    }

    public string GetLangId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(nameof(ApplicationUser.LanguageId))?.Value ?? string.Empty;
    }

    public string GetShopId()
    {
        // The claim name deliberately matches ApplicationUser.ShopId so token creation
        // and tenant filtering use the same contract.
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(nameof(ApplicationUser.ShopId))?.Value ?? string.Empty;
    }

    public bool IsRetailAdmin()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.IsInRole(SD.Role_Admin) ?? false;
    }

    public bool IsWholesaleAdmin()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.IsInRole(SD.Role_Admin) ?? false;
    }

    public bool IsSuperAdmin()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.IsInRole(SD.Role_Super_Admin) ?? false;
    }

    public List<string> Roles()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList() ?? new List<string>();
    }
}