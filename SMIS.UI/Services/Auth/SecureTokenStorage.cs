namespace SMIS.UI.Services.Auth;

public interface ITokenStorage
{
    Task<string?> GetTokenAsync();
    Task SetTokenAsync(string token);
    Task ClearTokenAsync();
}

public class SecureTokenStorage : ITokenStorage
{
    private const string TokenKey = "jwt_token";

    public async Task<string?> GetTokenAsync()
    {
        try
        {
            return await Microsoft.Maui.Storage.SecureStorage.Default.GetAsync(TokenKey);
        }
        catch
        {
            return null;
        }
    }

    public async Task SetTokenAsync(string token)
    {
        await Microsoft.Maui.Storage.SecureStorage.Default.SetAsync(TokenKey, token);
    }

    public async Task ClearTokenAsync()
    {
        Microsoft.Maui.Storage.SecureStorage.Default.Remove(TokenKey);
        await Task.CompletedTask;
    }
}
