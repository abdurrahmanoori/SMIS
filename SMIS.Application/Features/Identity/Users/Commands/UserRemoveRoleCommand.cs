using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserRemoveRoleCommand(string UserId, string Role) : IRequest<Result<Unit>>;

    public class UserRemoveRoleCommandHandler : IRequestHandler<UserRemoveRoleCommand, Result<Unit>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRemoveRoleCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<Unit>> Handle(UserRemoveRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<Unit>.NotFoundResult(request.UserId);

            var removeResult = await _userManager.RemoveFromRoleAsync(user, request.Role);
            if (!removeResult.Succeeded)
                return Result<Unit>.WithErrors(removeResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());

            return Result<Unit>.SuccessResult(Unit.Value, "Role removed successfully");
        }
    }
}