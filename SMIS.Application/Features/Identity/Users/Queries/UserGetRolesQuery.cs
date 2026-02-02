using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetRolesQuery(string UserId) : IRequest<Result<IList<string>>>;

    public class UserGetRolesQueryHandler : IRequestHandler<UserGetRolesQuery, Result<IList<string>>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserGetRolesQueryHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<IList<string>>> Handle(UserGetRolesQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<IList<string>>.NotFoundResult(request.UserId);

            var roles = await _userManager.GetRolesAsync(user);
            return Result<IList<string>>.SuccessResult(roles, "User roles retrieved successfully");
        }
    }
}