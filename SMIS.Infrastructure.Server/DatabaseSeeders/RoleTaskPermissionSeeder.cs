using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class RoleTaskPermissionSeeder
{
    private static readonly string[] TaskIds =
    [
        AuthorizationSeedIds.TaskReceiveStock,
        AuthorizationSeedIds.TaskProcessCustomerReturn,
        AuthorizationSeedIds.TaskProcessSupplierReturn,
        AuthorizationSeedIds.TaskMarkDamagedStock,
        AuthorizationSeedIds.TaskMarkExpiredStock,
        AuthorizationSeedIds.TaskAdjustStock,
        AuthorizationSeedIds.TaskTransferStock,
        AuthorizationSeedIds.TaskStartStockCount,
        AuthorizationSeedIds.TaskCompleteStockCount,
        AuthorizationSeedIds.TaskCancelStockCount,
        AuthorizationSeedIds.TaskReverseStockMovement
    ];

    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        var allowedRoles = new HashSet<string>(StringComparer.Ordinal)
        {
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleInventoryManager
        };

        var roles = new[]
        {
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleInventoryManager,
            SeedIds.RoleSalesManager,
            SeedIds.RoleCashier,
            SeedIds.RoleStaff,
            SeedIds.RoleViewer
        };

        modelBuilder.Entity<RoleTaskPermission>().HasData(
            roles.SelectMany(roleId => TaskIds.Select(taskId => new RoleTaskPermission
            {
                RoleId = roleId,
                TaskId = taskId,
                IsAllowed = allowedRoles.Contains(roleId)
            })));

        var purchasingAllowedRoles = AllowedRoles(
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleInventoryManager);

        var saleReturnAllowedRoles = AllowedRoles(
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleSalesManager,
            SeedIds.RoleCashier);

        var saleVoidAllowedRoles = AllowedRoles(
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleSalesManager);

        var paymentAllowedRoles = AllowedRoles(
            SeedIds.RoleSuperAdmin,
            SeedIds.RoleShopAdmin,
            SeedIds.RoleManager,
            SeedIds.RoleSalesManager,
            SeedIds.RoleCashier);

        modelBuilder.Entity<RoleTaskPermission>().HasData(
            PermissionsFor(roles, AuthorizationSeedIds.TaskReceivePurchaseOrder, purchasingAllowedRoles)
                .Concat(PermissionsFor(roles, AuthorizationSeedIds.TaskProcessPurchaseOrderSupplierReturn, purchasingAllowedRoles))
                .Concat(PermissionsFor(roles, AuthorizationSeedIds.TaskCancelPurchaseOrder, purchasingAllowedRoles))
                .Concat(PermissionsFor(roles, AuthorizationSeedIds.TaskProcessSaleReturn, saleReturnAllowedRoles))
                .Concat(PermissionsFor(roles, AuthorizationSeedIds.TaskVoidSale, saleVoidAllowedRoles))
                .Concat(PermissionsFor(roles, AuthorizationSeedIds.TaskProcessCustomerPayment, paymentAllowedRoles)));
    }

    private static HashSet<string> AllowedRoles(
        params string[] roleIds
    ) => new(roleIds, StringComparer.Ordinal);

    private static IEnumerable<RoleTaskPermission> PermissionsFor(
        IEnumerable<string> roleIds,
        string taskId,
        HashSet<string> allowedRoles
    ) => roleIds.Select(roleId => new RoleTaskPermission
    {
        RoleId = roleId,
        TaskId = taskId,
        IsAllowed = allowedRoles.Contains(roleId)
    });
}
