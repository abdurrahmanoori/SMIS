namespace SMIS.Infrastructure.Mobile.Services.Identity;

public interface ILocalCurrentUser
{
    string GetId();
    string GetDeviceId();
    string GetShopId();
    void SetUser(string userId, string shopId);
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
