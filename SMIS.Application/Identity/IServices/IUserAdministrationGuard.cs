using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Identity.IServices;

public interface IUserAdministrationGuard
{
    Task<bool> CanManageUserAsync(
        ApplicationUser targetUser,
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
}