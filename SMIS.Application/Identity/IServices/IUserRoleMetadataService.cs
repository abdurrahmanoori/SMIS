namespace SMIS.Application.Identity.IServices;

public interface IUserRoleMetadataService
{
    Task SynchronizeAsync(
        string userId,
        string userName,
        CancellationToken cancellationToken = default
    );
}
