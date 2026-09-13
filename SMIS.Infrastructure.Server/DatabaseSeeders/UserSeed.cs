using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Contants;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UserSeed
{
    // Every seeded account uses its canonical role name at its shop domain.
    // Example: admin@mainstore.com, admin@branchstore.com.
    // Password for all seeded users: Pass123!
    private const string SeedPasswordHash =
        "AQAAAAIAAYagAAAAEE0b5rQqY7JDcZPxjM2CJxuH16YriSpqTeSLO+7ys67UK89RbdA3SnUC2ymyF8fZEw==";

    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ApplicationUser>().HasData(
            // Main Store
            CreateUser(SeedIds.UserSuperAdmin, SD.Role_Super_Admin, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainAdmin, SD.Role_Admin, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainAdministration, SD.Role_Administration, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainManager, SD.Role_Manager, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainStaff, SD.Role_Staff, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainViewer, SD.Role_Viewer, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainEditor, SD.Role_Editor, SeedIds.Shop1),
            CreateUser(SeedIds.UserMainUser, SD.Role_User, SeedIds.Shop1),

            // Branch Store
            CreateUser(SeedIds.UserBranchAdmin, SD.Role_Admin, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchAdministration, SD.Role_Administration, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchManager, SD.Role_Manager, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchStaff, SD.Role_Staff, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchViewer, SD.Role_Viewer, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchEditor, SD.Role_Editor, SeedIds.Shop2),
            CreateUser(SeedIds.UserBranchUser, SD.Role_User, SeedIds.Shop2),

            // Wasil Shop
            CreateUser(SeedIds.UserWasilAdmin, SD.Role_Admin, SeedIds.ShopWasil)
        );
    }

    internal static string GetSeedEmail(
        string roleName,
        string shopId
    )
        => $"{roleName.ToLowerInvariant()}@{GetShopDomain(shopId)}.com";

    private static ApplicationUser CreateUser(
        string id,
        string roleName,
        string shopId
    )
    {
        var email = GetSeedEmail(roleName, shopId);
        var user = ApplicationUser.Create(email, email, shopId, GetShopName(shopId), roleName, null, SeedIds.LangEn);

        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.Id))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ShopName))!.SetValue(user, GetShopName(shopId));
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.EmailConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PhoneNumberConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.SecurityStamp))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ConcurrencyStamp))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedUserName))!.SetValue(user,
            email.ToUpperInvariant());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedEmail))!.SetValue(user, email.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PasswordHash))!.SetValue(user, SeedPasswordHash);

        return user;
    }

    private static string GetShopDomain(
        string shopId
    ) => shopId switch
    {
        SeedIds.Shop1 => "mainstore",
        SeedIds.Shop2 => "branchstore",
        SeedIds.Shop3 => "warehouse",
        SeedIds.ShopWasil => "wasilshop",
        _ => "smis"
    };

    private static string? GetShopName(
        string shopId
    ) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        SeedIds.ShopWasil => "Wasil Shop",
        _ => null
    };
}