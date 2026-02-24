using Microsoft.AspNetCore.Http;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Infrastructure.Server.Services.Identity;

public class ServerCurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ServerCurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "1";
    }

    public string GetLangId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(nameof(ApplicationUser.LanguageId))?.Value ?? "1";
    }

    public string GetShopId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.FindFirst(nameof(ApplicationUser.ShopId))?.Value ?? string.Empty;
    }

    public bool IsRetailAdmin()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.IsInRole(SD.Role_RShop_Admin) ?? false;
    }

    public bool IsWholesaleAdmin()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        return user?.IsInRole(SD.Role_WShop_Admin) ?? false;
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
