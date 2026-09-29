using SMIS.Application.DTO.Auth;
using SMIS.Domain.Enums;

namespace SMIS.Application.Identity.IServices;

public interface IComponentPermissionService
{
    Task<IReadOnlyList<ComponentPermissionDto>> GetEffectivePermissionsAsync(
        string userId,
        CancellationToken cancellationToken = default
    );

    Task<bool> HasPermissionAsync(
        string userId,
        string componentKey,
        PermissionAction action,
        CancellationToken cancellationToken = default
    );
}
