namespace SMIS.Application.Identity.IServices;

public interface IUserAdministrationGuard
{
    Task<bool> WouldRemoveLastSuperAdminAsync(
        string userId,
        CancellationToken cancellationToken = default
    );
}
