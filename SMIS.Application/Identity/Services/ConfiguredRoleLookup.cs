using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Identity.Services;

public static class ConfiguredRoleLookup
{
    public static async Task<string?[]> ResolveAsync(RoleManager<ApplicationRole> manager, IEnumerable<string> names)
    {
        var roles = new List<string?>();
        foreach (var name in names)
            roles.Add(string.IsNullOrWhiteSpace(name) ? null : (await manager.FindByNameAsync(name.Trim()))?.Name);
        return roles.ToArray();
    }
}
