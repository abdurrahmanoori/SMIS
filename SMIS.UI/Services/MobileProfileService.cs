using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Infrastructure.Mobile.Services.Http;
using SMIS.Infrastructure.Mobile.Services.Identity;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.UI.Services;

/// <summary>
/// Mobile implementation of IProfileService.
/// Fetches full user details from the API (GET /api/account/me).
/// Delegates password change to the API (POST /api/account/{id}/change-password).
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

    public async Task<Result<ProfileDto>> GetCurrentUserAsync()
    {
        var result = await _apiClient.GetAsync<UserDto>("/api/account/me?includeShop=true");

        if (!result.Success || result.Response == null)
            return Result<ProfileDto>.FailureResult(result.Message ?? result.Errors?.FirstOrDefault()?.Description ?? "Failed to load profile.");

        var user = result.Response;
        return Result<ProfileDto>.SuccessResult(new ProfileDto
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            FirstName = user.FirstName,
            LastName = user.LastName,
            ShopName = user.Shop?.Name ?? user.ShopId,
            LanguageId = user.LanguageId,
            EmailConfirmed = user.EmailConfirmed,
            PhoneNumberConfirmed = user.PhoneNumberConfirmed,
            Roles = user.Roles ?? new List<string>()
        });
    }

    public async Task<Result> ChangePasswordAsync(string currentPassword, string newPassword)
    {
        var userId = _currentUser.GetId();
        var result = await _apiClient.PostAsync<ChangePasswordDto, bool>(
            $"/api/account/{userId}/change-password",
            new ChangePasswordDto { CurrentPassword = currentPassword, NewPassword = newPassword });

        return result.Success
            ? new Result { Success = true, Message = result.Message }
            : new Result { Success = false, Message = result.Message };
    }
}
