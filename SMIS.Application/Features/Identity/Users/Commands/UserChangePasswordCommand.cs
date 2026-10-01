using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserChangePasswordCommand(string UserId, ChangePasswordDto Dto) : IRequest<Result>;

    public class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommand, Result>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICurrentUser _currentUser;

        public UserChangePasswordCommandHandler(
            UserManager<ApplicationUser> userManager,
            ICurrentUser currentUser
        )
        {
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<Result> Handle(
            UserChangePasswordCommand request,
            CancellationToken cancellationToken
        )
        {
            if (!string.Equals(request.UserId, _currentUser.GetId(), StringComparison.Ordinal))
            {
                return Result.Forbidden(
                    "Forbidden",
                    "You can only change your own password.");
            }

            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result.NotFound(request.UserId);

            var result =
                await _userManager.ChangePasswordAsync(user, request.Dto.CurrentPassword, request.Dto.NewPassword);
            if (!result.Succeeded)
            {
                return Result.Failure(result.Errors.Select(e => new Error
                {
                    Code = e.Code,
                    Description = e.Description
                }).ToList());
            }

            return Result.Success();
        }
    }
}