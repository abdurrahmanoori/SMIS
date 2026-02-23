using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Infrastructure.Mobile.Services.Identity;

public interface IMobileCurrentUser : ICurrentUser
{
    void SetUser(ClaimsPrincipal user);
    void ClearUser();
    string GetDeviceId();
}

public class MobileCurrentUser : IMobileCurrentUser
{
    private ClaimsPrincipal? _currentUser;
    private readonly string _deviceId;

    public MobileCurrentUser()
    {
        _deviceId = Preferences.Get("DeviceId", Guid.NewGuid().ToString());
        Preferences.Set("DeviceId", _deviceId);
    }

    public void SetUser(ClaimsPrincipal user)
    {
        _currentUser = user;
        
        var userId = GetId();
        var shopId = GetShopId();
        Preferences.Set("UserId", userId);
        Preferences.Set("ShopId", shopId);
    }

    public void ClearUser()
    {
        _currentUser = null;
    }

    public string GetId()
    {
        return _currentUser?.FindFirst(ClaimTypes.NameIdentifier)?.Value 
            ?? Preferences.Get("UserId", "offline-user");
    }

    public string GetLangId()
    {
        return _currentUser?.FindFirst(nameof(ApplicationUser.LanguageId))?.Value ?? "1";
    }

    public string GetShopId()
    {
        return _currentUser?.FindFirst(nameof(ApplicationUser.ShopId))?.Value 
            ?? Preferences.Get("ShopId", string.Empty);
    }

    public string GetDeviceId() => _deviceId;

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
