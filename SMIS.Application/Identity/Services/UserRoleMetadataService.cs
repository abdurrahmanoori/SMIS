using Microsoft.EntityFrameworkCore;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Identity.Services;

public sealed class UserRoleMetadataService : IUserRoleMetadataService
{
    private readonly IApplicationDbContext _context;

    public UserRoleMetadataService(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task SynchronizeAsync(
        string userId,
        string userName,
        CancellationToken cancellationToken = default
    )
    {
        var assignments = await _context.UserRoles
            .Where(userRole => userRole.UserId == userId)
            .ToListAsync(cancellationToken);

        if (assignments.Count == 0) return;

        var roleIds = assignments.Select(userRole => userRole.RoleId).Distinct().ToArray();
        var roleNames = await _context.Roles
            .AsNoTracking()
            .Where(role => roleIds.Contains(role.Id))
            .ToDictionaryAsync(role => role.Id, role => role.Name, cancellationToken);

        foreach (var assignment in assignments)
        {
            assignment.UserName = userName;
            assignment.RoleName = roleNames.GetValueOrDefault(assignment.RoleId);
        }

        await _context.SaveChangesAsync(cancellationToken);
    }
}
