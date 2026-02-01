using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Users;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserChangePasswordCommand(string UserId, ChangePasswordDto Dto) : IRequest<Result<Unit>>;

    public class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommand, Result<Unit>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserChangePasswordCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<Unit>> Handle(UserChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<Unit>.NotFoundResult(request.UserId);

            var result = await _userManager.ChangePasswordAsync(user, request.Dto.CurrentPassword, request.Dto.NewPassword);
            if (!result.Succeeded)
            {
                return Result<Unit>.WithErrors(result.Errors.Select(e => new ValidationError
                {
                    Code = e.Code,
                    Description = e.Description
                }).ToList());
            }

            return Result<Unit>.SuccessResult(Unit.Value, "Password changed successfully");
        }
    }
}
