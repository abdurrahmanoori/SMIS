using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserAssignRolesCommand(string UserId, IEnumerable<string> Roles) : IRequest<Result<Unit>>;

    public class UserAssignRolesCommandHandler : IRequestHandler<UserAssignRolesCommand, Result<Unit>>
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

        public async Task<Result<Unit>> Handle(
            UserAssignRolesCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result<Unit>.NotFoundResult(request.UserId);

            var requestedRoles = request.Roles
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();
            var canonicalRoles = requestedRoles
                .Select(SD.GetCanonicalRole)
                .ToArray();

            if (canonicalRoles.Any(role => role is null))
            {
                return Result<Unit>.FailureResult(
                    "InvalidRole",
                    $"Roles must be one of: {string.Join(", ", SD.AllRoles)}.");
            }

            var roles = canonicalRoles.Cast<string>().ToArray();

            foreach (var role in roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                    return Result<Unit>.FailureResult("InvalidRole", $"Role '{role}' is not configured.");
            }

            if (!roles.Contains(SD.Role_Super_Admin, StringComparer.OrdinalIgnoreCase) &&
                await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                    user.Id,
                    cancellationToken))
            {
                return Result<Unit>.FailureResult(
                    "LastSuperAdmin",
                    "The SuperAdmin role cannot be removed from the last SuperAdmin account.");
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var toRemove = currentRoles.Except(roles, StringComparer.OrdinalIgnoreCase).ToArray();
            var toAdd = roles.Except(currentRoles, StringComparer.OrdinalIgnoreCase).ToArray();

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                if (toRemove.Length > 0)
                {
                    var removeResult = await _userManager.RemoveFromRolesAsync(user, toRemove);
                    if (!removeResult.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return Result<Unit>.WithErrors(removeResult.Errors.Select(e => new ValidationError
                            { Code = e.Code, Description = e.Description }).ToList());
                    }
                }

                if (toAdd.Length > 0)
                {
                    var addResult = await _userManager.AddToRolesAsync(user, toAdd);
                    if (!addResult.Succeeded)
                    {
                        await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                        return Result<Unit>.WithErrors(addResult.Errors.Select(e => new ValidationError
                            { Code = e.Code, Description = e.Description }).ToList());
                    }
                }

                await _userRoleMetadataService.SynchronizeAsync(
                    user.Id,
                    user.UserName ?? string.Empty,
                    cancellationToken);
                await _unitOfWork.CommitTransactionAsync(cancellationToken);

                return Result<Unit>.SuccessResult(Unit.Value, "Roles assigned successfully");
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