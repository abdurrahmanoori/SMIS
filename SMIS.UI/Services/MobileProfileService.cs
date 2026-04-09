using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.UI.Services;

/// <summary>
/// Mobile implementation of IProfileService.
/// Reads profile data from the public API of IMobileCurrentUser (backed by JWT claims).
/// Delegates password change to the REST API.
/// </summary>
public class MobileProfileService : IProfileService
{
    private readonly IMobileCurrentUser _currentUser;
    private readonly IApiClient _apiClient;

    public MobileProfileService(IMobileCurrentUser currentUser, IApiClient apiClient)
    {
        _currentUser = currentUser;
        _apiClient = apiClient;
    }

    public Task<Result<ProfileDto>> GetCurrentUserAsync()
    {
        var dto = new ProfileDto
        {
            Id = _currentUser.GetId(),
            ShopName = _currentUser.GetShopId(),
            LanguageId = _currentUser.GetLangId(),
            Roles = _currentUser.Roles(),
            // UserName, Email, Phone, FirstName, LastName are not exposed by IMobileCurrentUser.
            // They would require an API call — left null here; extend if needed.
        };

        return Task.FromResult(Result<ProfileDto>.SuccessResult(dto));
    }

    public async Task<Result> ChangePasswordAsync(string currentPassword, string newPassword)
    {
        var userId = _currentUser.GetId();
        var result = await _apiClient.PostAsync<ChangePasswordDto, bool>(
            $"/api/users/{userId}/change-password",
            new ChangePasswordDto { CurrentPassword = currentPassword, NewPassword = newPassword });

        return result.Success
            ? new Result { Success = true, Message = result.Message }
            : new Result { Success = false, Message = result.Message };
    }
}
