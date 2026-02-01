using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserDeleteCommand(string UserId) : IRequest<Result<Unit>>;

    public class UserDeleteCommandHandler : IRequestHandler<UserDeleteCommand, Result<Unit>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserDeleteCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<Unit>> Handle(UserDeleteCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<Unit>.NotFoundResult(request.UserId);

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded)
            {
                return Result<Unit>.WithErrors(result.Errors.Select(e => new ValidationError
                {
                    Code = e.Code,
                    Description = e.Description
                }).ToList());
            }

            return Result<Unit>.SuccessResult(Unit.Value, "User deleted successfully");
        }
    }
}
