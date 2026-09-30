using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Identity.Services;

public sealed class TaskPermissionService : ITaskPermissionService
{
    private readonly IApplicationDbContext _context;

    public TaskPermissionService(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<IReadOnlyList<string>> GetEffectiveTaskPermissionsAsync(
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(userId)) return Array.Empty<string>();

        var roleIds = await _context.UserRoles
            .AsNoTracking()
            .Where(userRole => userRole.UserId == userId)
            .Select(userRole => userRole.RoleId)
            .ToListAsync(cancellationToken);

        if (roleIds.Count == 0) return Array.Empty<string>();

        var isSuperAdmin = await _context.Roles
            .AsNoTracking()
            .AnyAsync(
                role => roleIds.Contains(role.Id) && role.Name == SD.Role_Super_Admin,
                cancellationToken);

        if (isSuperAdmin)
        {
            return await _context.ApplicationTasks
                .AsNoTracking()
                .Where(task => task.IsActive)
                .OrderBy(task => task.Name)
                .Select(task => task.Key)
                .ToListAsync(cancellationToken);
        }

        return await _context.RoleTaskPermissions
            .AsNoTracking()
            .Where(permission =>
                roleIds.Contains(permission.RoleId) &&
                permission.IsAllowed &&
                permission.Task.IsActive)
            .Select(permission => permission.Task.Key)
            .Distinct()
            .OrderBy(key => key)
            .ToListAsync(cancellationToken);
    }

    public async Task<bool> HasTaskPermissionAsync(
        string userId,
        string taskKey,
        CancellationToken cancellationToken = default
    )
    {
        var tasks = await GetEffectiveTaskPermissionsAsync(userId, cancellationToken);
        return tasks.Contains(taskKey, StringComparer.OrdinalIgnoreCase);
    }
}
