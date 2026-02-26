namespace SMIS.UI.Services;

public class DevelopmentAutoLoginService
{
    private readonly AuthServiceWrapper _authService;
    private const string DevUsername = "superadmin@smis.com";
    private const string DevPassword = "Pass123!";

    public DevelopmentAutoLoginService(AuthServiceWrapper authService)
    {
        _authService = authService;
    }

    public async Task<bool> TryAutoLoginAsync()
    {
#if DEBUG
        var isAuthenticated = await _authService.IsAuthenticatedAsync();
        if (!isAuthenticated)
        {
            var result = await _authService.LoginAsync(DevUsername, DevPassword);
            return result.Success;
        }
        return true;
#else
        return await _authService.IsAuthenticatedAsync();
#endif
    }
}
