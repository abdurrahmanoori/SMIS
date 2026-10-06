using MediatR;
using SMIS.Application.Identity.Services;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserAssignRolesCommand(string UserId, IEnumerable<string> Roles) : IRequest<Result>;

    public class UserAssignRolesCommandHandler : IRequestHandler<UserAssignRolesCommand, Result>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRoleMetadataService _userRoleMetadataService;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserAssignRolesCommandHandler(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IUnitOfWork unitOfWork,
            IUserRoleMetadataService userRoleMetadataService,
            IUserAdministrationGuard userAdministrationGuard
        )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
            _userRoleMetadataService = userRoleMetadataService;
            _userAdministrationGuard = userAdministrationGuard;
        }

        public async Task<Result> Handle(
            UserAssignRolesCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result.NotFound(request.UserId);

            var requestedRoles = request.Roles
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();
            var canonicalRoles = await ConfiguredRoleLookup.ResolveAsync(_roleManager, requestedRoles);

            if (canonicalRoles.Any(role => role is null))
            {
                return Result.BusinessRule(
                    "InvalidRole",
                    "One or more requested roles are not configured.");
            }

            var roles = canonicalRoles.Cast<string>().ToArray();

            foreach (var role in roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                    return Result.BusinessRule("InvalidRole", $"Role '{role}' is not configured.");
            }

            if (!await _userAdministrationGuard.CanAssignRolesAsync(
                    user,
                    roles,
                    cancellationToken))
            {
                return Result.Forbidden(
                    "user.role_assignment_forbidden",
                    "You are not allowed to assign the requested roles to this user.");
            }

            if (!roles.Contains(SD.Role_Super_Admin, StringComparer.OrdinalIgnoreCase) &&
                await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                    user.Id,
                    cancellationToken))
            {
                return Result.BusinessRule(
                    "LastSuperAdmin",
                    "The SuperAdmin role cannot be removed from the last SuperAdmin account.");
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var toRemove = currentRoles.Except(roles, StringComparer.OrdinalIgnoreCase).ToArray();
            var toAdd = roles.Except(currentRoles, StringComparer.OrdinalIgnoreCase).ToArray();

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                if (toRemove.Length > 0 || toAdd.Length > 0)
                    user.InvalidateSessions();

                if (toRemove.Length > 0)
                {
                    var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                    if (!removeResult.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return Result.Failure(removeResult.Errors.Select(e => new Error
                            { Code = e.Code, Description = e.Description }).ToList());
                    }
                }

                if (toAdd.Length > 0)
                {
                    var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                    if (!addResult.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return Result.Failure(addResult.Errors.Select(e => new Error
                            { Code = e.Code, Description = e.Description }).ToList());
                    }
                }

                await _userRoleMetadataService.SynchronizeAsync(
                    user.Id,
                    user.UserName ?? string.Empty,
                    cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);

                return Result.Success();
            }
            catch
            {
                if (_unitOfWork.HasActiveTransaction)
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                throw;
            }
        }
    }
}
