using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Enums;

namespace SMIS.Application.Identity.Services;

public sealed class ComponentPermissionService : IComponentPermissionService
{
    private readonly IApplicationDbContext _context;

    public ComponentPermissionService(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<IReadOnlyList<ComponentPermissionDto>> GetEffectivePermissionsAsync(
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        var components = await _context.ApplicationComponents
            .AsNoTracking()
            .Where(component => component.IsActive)
            .OrderBy(component => component.DisplayOrder)
            .ToListAsync(cancellationToken);

        if (components.Count == 0 || string.IsNullOrWhiteSpace(userId))
            return Array.Empty<ComponentPermissionDto>();

        var roleIds = await _context.UserRoles
            .AsNoTracking()
            .Where(userRole => userRole.UserId == userId)
            .Select(userRole => userRole.RoleId)
            .ToListAsync(cancellationToken);

        var isSuperAdmin = roleIds.Count > 0 && await _context.Roles
            .AsNoTracking()
            .AnyAsync(
                role => roleIds.Contains(role.Id) && role.Name == SD.Role_Super_Admin,
                cancellationToken);

        if (isSuperAdmin)
        {
            return components.Select(component => new ComponentPermissionDto
            {
                ComponentKey = component.Key,
                CanView = true,
                CanRead = true,
                CanCreate = true,
                CanUpdate = true,
                CanDelete = true
            }).ToList();
        }

        var componentIds = components.Select(component => component.Id).ToArray();
        var rolePermissions = roleIds.Count == 0
            ? []
            : await _context.RoleComponentPermissions
                .AsNoTracking()
                .Where(permission =>
                    roleIds.Contains(permission.RoleId) &&
                    componentIds.Contains(permission.ComponentId))
                .ToListAsync(cancellationToken);

        return components.Select(component =>
        {
            var grants = rolePermissions.Where(permission => permission.ComponentId == component.Id).ToArray();
            return new ComponentPermissionDto
            {
                ComponentKey = component.Key,
                CanView = grants.Any(permission => permission.CanView),
                CanRead = grants.Any(permission => permission.CanRead),
                CanCreate = grants.Any(permission => permission.CanCreate),
                CanUpdate = grants.Any(permission => permission.CanUpdate),
                CanDelete = grants.Any(permission => permission.CanDelete)
            };
        }).ToList();
    }

    public async Task<bool> HasPermissionAsync(
        string userId,
        string componentKey,
        PermissionAction action,
        CancellationToken cancellationToken = default
    )
    {
        var permissions = await GetEffectivePermissionsAsync(userId, cancellationToken);
        var permission = permissions.FirstOrDefault(item =>
            string.Equals(item.ComponentKey, componentKey, StringComparison.OrdinalIgnoreCase));

        if (permission is null) return false;

        return action switch
        {
            PermissionAction.View => permission.CanView,
            PermissionAction.Read => permission.CanRead,
            PermissionAction.Create => permission.CanCreate,
            PermissionAction.Update => permission.CanUpdate,
            PermissionAction.Delete => permission.CanDelete,
            _ => false
        };
    }
}
