using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class UserSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        modelBuilder.Entity<ApplicationUser>().HasData(
            CreateUser(SeedIds.UserSuperAdmin,      "superadmin",      "superadmin@smis.com",      SeedIds.Shop1, "Super",     "Admin",          "+855123456789", hasher),

            // Wholesale Shop Users
            CreateUser(SeedIds.UserWAdmin,          "wadmin",          "wadmin@smis.com",          SeedIds.Shop1, "Wholesale", "Admin",          "+855123456790", hasher),
            CreateUser(SeedIds.UserWAdministration, "wadministration", "wadministration@smis.com", SeedIds.Shop1, "Wholesale", "Administration", "+855123456791", hasher),
            CreateUser(SeedIds.UserWManager,        "wmanager",        "wmanager@smis.com",        SeedIds.Shop1, "Wholesale", "Manager",        "+855123456792", hasher),
            CreateUser(SeedIds.UserWStaff,          "wstaff",          "wstaff@smis.com",          SeedIds.Shop1, "Wholesale", "Staff",          "+855123456793", hasher),
            CreateUser(SeedIds.UserWViewer,         "wviewer",         "wviewer@smis.com",         SeedIds.Shop1, "Wholesale", "Viewer",         "+8512345634366", hasher),
            CreateUser(SeedIds.UserWEditor,         "weditor",         "weditor@smis.com",         SeedIds.Shop1, "Wholesale", "Editor",         "+855123456795", hasher),
            CreateUser(SeedIds.UserWUser,           "wuser",           "wuser@smis.com",           SeedIds.Shop1, "Wholesale", "User",           "+855123456796", hasher),

            // Retail Shop Users
            CreateUser(SeedIds.UserRAdmin,          "radmin",          "radmin@smis.com",          SeedIds.Shop2, "Retail",    "Admin",          "+855123456797", hasher),
            CreateUser(SeedIds.UserRAdministration, "radministration", "radministration@smis.com", SeedIds.Shop2, "Retail",    "Administration", "+855123456798", hasher),
            CreateUser(SeedIds.UserRManager,        "rmanager",        "rmanager@smis.com",        SeedIds.Shop2, "Retail",    "Manager",        "+855123456799", hasher),
            CreateUser(SeedIds.UserRStaff,          "rstaff",          "rstaff@smis.com",          SeedIds.Shop2, "Retail",    "Staff",          "+855123456800", hasher),
            CreateUser(SeedIds.UserRViewer,         "rviewer",         "rviewer@smis.com",         SeedIds.Shop2, "Retail",    "Viewer",         "+855123456801", hasher),
            CreateUser(SeedIds.UserREditor,         "reditor",         "reditor@smis.com",         SeedIds.Shop2, "Retail",    "Editor",         "+855123456802", hasher),
            CreateUser(SeedIds.UserRUser,           "ruser",           "ruser@smis.com",           SeedIds.Shop2, "Retail",    "User",           "+855123456803", hasher)
        );
    }

    private static ApplicationUser CreateUser(string id, string userName, string email, string shopId, string? firstName, string? lastName, string? phoneNumber, PasswordHasher<ApplicationUser> hasher)
    {
        var user = ApplicationUser.Create(userName, email, shopId, firstName, lastName, phoneNumber, SeedIds.LangEn);

        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.Id))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ShopName))!.SetValue(user, GetShopName(shopId));
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.EmailConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PhoneNumberConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.SecurityStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ConcurrencyStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedUserName))!.SetValue(user, userName.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedEmail))!.SetValue(user, email.ToUpper());

        // Hash password "Pass123!"
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PasswordHash))!.SetValue(user, hasher.HashPassword(user, "Pass123!"));

        return user;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        _ => null
    };
}
