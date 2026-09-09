using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UserSeed
{
    // Simple, easy-to-remember credentials for every seeded account:
    //   Email    = <username>@<shop>.com   (e.g. wadmin@mainstore.com)
    //   Password = Pass123!                (the same for all users)
    private const string SeedPassword = "Pass123!";

    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        modelBuilder.Entity<ApplicationUser>().HasData(
            // Main Store (Shop1) — Super Admin
            CreateUser(SeedIds.UserSuperAdmin, "superadmin", SeedIds.Shop1, "Super", "Admin", hasher),

            // Main Store (Shop1) — Wholesale roles
            CreateUser(SeedIds.UserWAdmin,          "wadmin",          SeedIds.Shop1, "Wholesale", "Admin",          hasher),
            CreateUser(SeedIds.UserWAdministration, "wadministration", SeedIds.Shop1, "Wholesale", "Administration", hasher),
            CreateUser(SeedIds.UserWManager,        "wmanager",        SeedIds.Shop1, "Wholesale", "Manager",        hasher),
            CreateUser(SeedIds.UserWStaff,          "wstaff",          SeedIds.Shop1, "Wholesale", "Staff",          hasher),
            CreateUser(SeedIds.UserWViewer,         "wviewer",         SeedIds.Shop1, "Wholesale", "Viewer",         hasher),
            CreateUser(SeedIds.UserWEditor,         "weditor",         SeedIds.Shop1, "Wholesale", "Editor",         hasher),
            CreateUser(SeedIds.UserWUser,           "wuser",           SeedIds.Shop1, "Wholesale", "User",           hasher),

            // Branch Store (Shop2) — Retail roles
            CreateUser(SeedIds.UserRAdmin,          "radmin",          SeedIds.Shop2, "Retail",    "Admin",          hasher),
            CreateUser(SeedIds.UserRAdministration, "radministration", SeedIds.Shop2, "Retail",    "Administration", hasher),
            CreateUser(SeedIds.UserRManager,        "rmanager",        SeedIds.Shop2, "Retail",    "Manager",        hasher),
            CreateUser(SeedIds.UserRStaff,          "rstaff",          SeedIds.Shop2, "Retail",    "Staff",          hasher),
            CreateUser(SeedIds.UserRViewer,         "rviewer",         SeedIds.Shop2, "Retail",    "Viewer",         hasher),
            CreateUser(SeedIds.UserREditor,         "reditor",         SeedIds.Shop2, "Retail",    "Editor",         hasher),
            CreateUser(SeedIds.UserRUser,           "ruser",           SeedIds.Shop2, "Retail",    "User",           hasher)
        );
    }

    private static ApplicationUser CreateUser(string id, string userName, string shopId, string? firstName, string? lastName, PasswordHasher<ApplicationUser> hasher)
    {
        var email = $"{userName}@{GetShopDomain(shopId)}.com";
        var user = ApplicationUser.Create(userName, email, shopId, firstName, lastName, null, SeedIds.LangEn);

        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.Id))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ShopName))!.SetValue(user, GetShopName(shopId));
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.EmailConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PhoneNumberConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.SecurityStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ConcurrencyStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedUserName))!.SetValue(user, userName.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedEmail))!.SetValue(user, email.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PasswordHash))!.SetValue(user, hasher.HashPassword(user, SeedPassword));

        return user;
    }

    // The shop domain is derived from the shop id, so the shop name is
    // always visible in the email (e.g. mainstore -> Main Store).
    private static string GetShopDomain(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "mainstore",
        SeedIds.Shop2 => "branchstore",
        SeedIds.Shop3 => "warehouse",
        _ => "smis"
    };

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        _ => null
    };
}
