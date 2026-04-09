using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Application.Features.Identity.Users.Queries;
using SMIS.UI.Shared.Services.Interfaces;

namespace SMIS.WebMaui.Services;

/// <summary>
/// Web implementation of IProfileService.
/// Uses MediatR to delegate to Application layer handlers that depend on UserManager.
/// </summary>
public class WebProfileService : IProfileService
{
    private readonly IMediator _mediator;

    public WebProfileService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Result<ProfileDto>> GetCurrentUserAsync()
    {
        var result = await _mediator.Send(new UserGetCurrentQuery(IncludeShop: true));

        if (!result.Success || result.Response == null)
            return Result<ProfileDto>.FailureResult(result.Message ?? "Failed to load profile.");

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
        // First resolve the current user's ID via the query
        var userResult = await _mediator.Send(new UserGetCurrentQuery());
        if (!userResult.Success || userResult.Response == null)
            return new Result { Success = false, Message = "Could not identify current user." };

        var result = await _mediator.Send(new UserChangePasswordCommand(
            userResult.Response.Id,
            new ChangePasswordDto { CurrentPassword = currentPassword, NewPassword = newPassword }));

        return result.Success
            ? new Result { Success = true, Message = result.Message }
            : new Result { Success = false, Message = result.Message };
    }
}
