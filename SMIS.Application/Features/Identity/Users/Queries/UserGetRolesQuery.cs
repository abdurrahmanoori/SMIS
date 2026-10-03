using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public record UserGetRolesQuery(string UserId) : IRequest<Result<IList<string>>>;

    public class UserGetRolesQueryHandler : IRequestHandler<UserGetRolesQuery, Result<IList<string>>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserGetRolesQueryHandler(
            UserManager<ApplicationUser> userManager,
            IUserAdministrationGuard userAdministrationGuard
        )
        {
            _userManager = userManager;
            _userAdministrationGuard = userAdministrationGuard;
        }

        public async Task<Result<IList<string>>> Handle(
            UserGetRolesQuery request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<IList<string>>.NotFound(request.UserId);

            if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
            {
                return Result<IList<string>>.Forbidden(
                    "user.administration_forbidden",
                    "You are not allowed to view roles for this user.");
            }

            var roles = await _userManager.GetRolesAsync(user);
            return Result<IList<string>>.Success(roles);
        }
    }
}
