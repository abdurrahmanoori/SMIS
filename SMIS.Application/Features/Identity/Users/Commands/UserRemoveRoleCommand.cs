using MediatR;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Common.Contants;
using SMIS.Application.Common.Response;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Commands
{
    public record UserRemoveRoleCommand(string UserId, string Role) : IRequest<Result>;

    public class UserRemoveRoleCommandHandler : IRequestHandler<UserRemoveRoleCommand, Result>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRoleMetadataService _userRoleMetadataService;
        private readonly IUserAdministrationGuard _userAdministrationGuard;

        public UserRemoveRoleCommandHandler(
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
            UserRemoveRoleCommand request,
            CancellationToken cancellationToken
        )
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user == null) return Result.NotFound(request.UserId);

            if (!await _userAdministrationGuard.CanManageUserAsync(user, cancellationToken))
            {
                return Result.Forbidden(
                    "user.administration_forbidden",
                    "You are not allowed to change roles for this user.");
            }

            var role = SD.GetCanonicalRole(request.Role);
            if (role is null || !await _roleManager.RoleExistsAsync(role))
                return Result.BusinessRule("InvalidRole", "The requested role is not configured.");

            if (string.Equals(role, SD.Role_Super_Admin, StringComparison.OrdinalIgnoreCase) &&
                await _userAdministrationGuard.WouldRemoveLastSuperAdminAsync(
                    user.Id,
                    cancellationToken))
            {
                return Result.BusinessRule(
                    "LastSuperAdmin",
                    "The SuperAdmin role cannot be removed from the last SuperAdmin account.");
            }

            await _unitOfWork.StartTransactionAsync(cancellationToken);
            try
            {
                user.InvalidateSessions();
                var removeResult = await _userManager.RemoveFromRoleAsync(user, role);
                if (!removeResult.Succeeded)
                {
                    await _unitOfWork.RollbackTransactionAsync(cancellationToken);
                    return Result.Failure(removeResult.Errors
                        .Select(e => new Error { Code = e.Code, Description = e.Description }).ToList());
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
