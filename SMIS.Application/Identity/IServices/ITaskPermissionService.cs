namespace SMIS.Application.Identity.IServices;

public interface ITaskPermissionService
{
    Task<IReadOnlyList<string>> GetEffectiveTaskPermissionsAsync(
        string userId,
        CancellationToken cancellationToken = default
    );

    Task<bool> HasTaskPermissionAsync(
        string userId,
        string taskKey,
        CancellationToken cancellationToken = default
    );
}
