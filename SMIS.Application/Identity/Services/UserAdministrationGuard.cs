using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Identity.Services;

public sealed class UserAdministrationGuard : IUserAdministrationGuard
{
    private readonly IApplicationDbContext _context;

    public UserAdministrationGuard(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<bool> WouldRemoveLastSuperAdminAsync(
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        var superAdminRoleId = await _context.Roles
            .AsNoTracking()
            .Where(role => role.Name == SD.Role_Super_Admin)
            .Select(role => role.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (string.IsNullOrWhiteSpace(superAdminRoleId)) return false;

        var targetIsSuperAdmin = await _context.UserRoles
            .AsNoTracking()
            .AnyAsync(
                userRole => userRole.UserId == userId && userRole.RoleId == superAdminRoleId,
                cancellationToken);

        if (!targetIsSuperAdmin) return false;

        var superAdminCount = await _context.UserRoles
            .AsNoTracking()
            .CountAsync(userRole => userRole.RoleId == superAdminRoleId, cancellationToken);

        return superAdminCount <= 1;
    }
}
