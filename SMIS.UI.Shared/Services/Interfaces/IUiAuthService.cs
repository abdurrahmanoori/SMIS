using SMIS.Application.Common.Response;

namespace SMIS.UI.Shared.Services.Interfaces;

public interface IUiAuthService
{
    Task<Result<LoginResponse>> LoginAsync(string userName, string password);
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}
