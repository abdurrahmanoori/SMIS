using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.UI.Services.Auth;

public class MauiCurrentUser : ICurrentUser
{
    private ClaimsPrincipal? _currentUser;

    public void SetUser(ClaimsPrincipal user)
    {
        _currentUser = user;
    }

    public void ClearUser()
    {
        _currentUser = null;
    }

    public string GetId()
    {
        return _currentUser?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "1";
    }

    public string GetLangId()
    {
        return _currentUser?.FindFirst(nameof(ApplicationUser.LanguageId))?.Value ?? "1";
    }

    public string GetShopId()
    {
        return _currentUser?.FindFirst(nameof(ApplicationUser.ShopId))?.Value ?? string.Empty;
    }

    public bool IsSuperAdmin()
    {
        return _currentUser?.IsInRole(SD.Role_Super_Admin) ?? false;
    }

    public bool IsWholesaleAdmin()
    {
        return _currentUser?.IsInRole(SD.Role_WShop_Admin) ?? false;
    }

    public bool IsRetailAdmin()
    {
        return _currentUser?.IsInRole(SD.Role_RShop_Admin) ?? false;
    }

    public List<string> Roles()
    {
        return _currentUser?.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList() ?? new List<string>();
    }
}
