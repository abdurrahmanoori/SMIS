using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class RoleComponentPermissionSeeder
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<RoleComponentPermission>().HasData(
            Permission(SeedIds.RoleSuperAdmin, true, true, true, true, true),
            Permission(SeedIds.RoleShopAdmin, true, true, true, true, true),
            Permission(SeedIds.RoleManager, true, true, true, true, true),
            Permission(SeedIds.RoleInventoryManager, true, true, true, true, true),
            Permission(SeedIds.RoleSalesManager, true, true, false, false, false),
            Permission(SeedIds.RoleCashier, true, true, false, false, false),
            Permission(SeedIds.RoleStaff, true, true, false, false, false),
            Permission(SeedIds.RoleViewer, true, true, false, false, false));
    }

    private static RoleComponentPermission Permission(
        string roleId,
        bool canView,
        bool canRead,
        bool canCreate,
        bool canUpdate,
        bool canDelete
    ) =>
        new()
        {
            RoleId = roleId,
            ComponentId = AuthorizationSeedIds.ComponentCategories,
            CanView = canView,
            CanRead = canRead,
            CanCreate = canCreate,
            CanUpdate = canUpdate,
            CanDelete = canDelete
        };
}
