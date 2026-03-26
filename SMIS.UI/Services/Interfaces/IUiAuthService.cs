using SMIS.Application.Common.Response;
using SMIS.Infrastructure.Mobile.Services.Auth;

namespace SMIS.UI.Services.Interfaces;

public interface IUiAuthService
{
    Task<Result<LoginResponse>> LoginAsync(string userName, string password);
    Task LogoutAsync();
    Task<bool> IsAuthenticatedAsync();
}
