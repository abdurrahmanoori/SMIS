using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Identity.IServices;

public interface IUserAdministrationGuard
{
    Task<bool> CanManageUserAsync(
        ApplicationUser targetUser,
        CancellationToken cancellationToken = default
    );

    Task<bool> CanCreateUserAsync(
        string shopId,
        IEnumerable<string> roles,
        CancellationToken cancellationToken = default
    );

    Task<bool> CanAssignRolesAsync(
        ApplicationUser targetUser,
        IEnumerable<string> roles,
        CancellationToken cancellationToken = default
    );

    Task<bool> WouldRemoveLastSuperAdminAsync(
        string userId,
        CancellationToken cancellationToken = default
    );

    Task<bool> WouldLockLastAvailableSuperAdminAsync(
        string userId,
        CancellationToken cancellationToken = default
    );

    Task<bool> WouldDeactivateLastAvailableSuperAdminAsync(
        string userId,
        CancellationToken cancellationToken = default
    );
}
