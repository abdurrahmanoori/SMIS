using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Identity.Services;

public sealed class UserAdministrationGuard : IUserAdministrationGuard
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserAdministrationGuard(
        IApplicationDbContext context,
        ICurrentUser currentUser,
        UserManager<ApplicationUser> userManager
    )
    {
        _context = context;
        _currentUser = currentUser;
        _userManager = userManager;
    }

    public async Task<bool> CanManageUserAsync(
        ApplicationUser targetUser,
        CancellationToken cancellationToken = default
    )
    {
        cancellationToken.ThrowIfCancellationRequested();

        var signedInUser = await _userManager.FindByIdAsync(_currentUser.GetId());
        if (signedInUser is null) return false;

        if (await _userManager.IsInRoleAsync(signedInUser, SD.Role_Super_Admin))
            return true;

        if (!await _userManager.IsInRoleAsync(signedInUser, SD.Role_Shop_Admin))
            return false;

        if (string.Equals(signedInUser.Id, targetUser.Id, StringComparison.Ordinal))
            return false;

        if (!string.Equals(signedInUser.ShopId, targetUser.ShopId, StringComparison.Ordinal))
            return false;

        return !await _userManager.IsInRoleAsync(targetUser, SD.Role_Super_Admin);
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

    public async Task<bool> WouldLockLastAvailableSuperAdminAsync(
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

        var now = DateTimeOffset.UtcNow;
        var anotherAvailableSuperAdminExists = await (
                from userRole in _context.UserRoles.AsNoTracking()
                join user in _userManager.Users.AsNoTracking()
                    on userRole.UserId equals user.Id
                where userRole.RoleId == superAdminRoleId && user.Id != userId
                select user)
            .AnyAsync(
                user => !user.LockoutEnabled || user.LockoutEnd == null || user.LockoutEnd <= now,
                cancellationToken);

        return !anotherAvailableSuperAdminExists;
    }
}