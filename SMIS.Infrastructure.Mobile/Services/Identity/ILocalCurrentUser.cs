using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Infrastructure.Mobile.Services.Identity;

public interface IMobileCurrentUser : ICurrentUser
{
    void SetUser(ClaimsPrincipal user);
    void ClearUser();
}

public interface ILocalCurrentUser
{
    string GetId();
    string GetDeviceId();
    string GetShopId();
    void SetUser(string userId, string shopId);
}

public class MobileCurrentUser : IMobileCurrentUser
{
    private ClaimsPrincipal? _currentUser;

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

public class LocalCurrentUser : ILocalCurrentUser
{
    private string _userId = "offline-user";
    private string _shopId = string.Empty;
    private string _deviceId = string.Empty;

    public LocalCurrentUser()
    {
        _deviceId = Preferences.Get("DeviceId", Guid.NewGuid().ToString());
        Preferences.Set("DeviceId", _deviceId);
        
        _userId = Preferences.Get("UserId", "offline-user");
        _shopId = Preferences.Get("ShopId", string.Empty);
    }

    public string GetId() => _userId;
    public string GetDeviceId() => _deviceId;
    public string GetShopId() => _shopId;

    public void SetUser(string userId, string shopId)
    {
        _userId = userId;
        _shopId = shopId;
        Preferences.Set("UserId", userId);
        Preferences.Set("ShopId", shopId);
    }
}
