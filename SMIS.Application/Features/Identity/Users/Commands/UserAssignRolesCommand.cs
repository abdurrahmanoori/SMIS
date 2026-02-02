using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserAssignRolesCommand(string UserId, IEnumerable<string> Roles) : IRequest<Result<Unit>>;

    public class UserAssignRolesCommandHandler : IRequestHandler<UserAssignRolesCommand, Result<Unit>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserAssignRolesCommandHandler(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Result<Unit>> Handle(UserAssignRolesCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<Unit>.NotFoundResult(request.UserId);

            var currentRoles = await _userManager.GetRolesAsync(user);
            var toRemove = currentRoles.Except(request.Roles).ToArray();
            var toAdd = request.Roles.Except(currentRoles).ToArray();

            if (toRemove.Length > 0)
            {
                var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                if (!removeResult.Succeeded)
                    return Result<Unit>.WithErrors(removeResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());
            }

            if (toAdd.Length > 0)
            {
                foreach (var role in toAdd)
                {
                    if (!await _roleManager.RoleExistsAsync(role))
                    {
                        var createRoleResult = await _roleManager.CreateAsync(new ApplicationRole { Name = role });
                        if (!createRoleResult.Succeeded)
                            return Result<Unit>.WithErrors(createRoleResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());
                    }
                }
                var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                if (!addResult.Succeeded)
                    return Result<Unit>.WithErrors(addResult.Errors.Select(e => new ValidationError { Code = e.Code, Description = e.Description }).ToList());
            }

            return Result<Unit>.SuccessResult(Unit.Value, "Roles assigned successfully");
        }
    }
}
