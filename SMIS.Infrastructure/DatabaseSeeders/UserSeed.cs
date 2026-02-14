using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class UserSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        
        modelBuilder.Entity<ApplicationUser>().HasData(
            CreateUser("1", "superadmin", "superadmin@smis.com", "1", "Super", "Admin", "+855123456789", hasher),
            
            // Wholesale Shop Users
            CreateUser("2", "wadmin", "wadmin@smis.com", "1", "Wholesale", "Admin", "+855123456790", hasher),
            CreateUser("3", "wadministration", "wadministration@smis.com", "1", "Wholesale", "Administration", "+855123456791", hasher),
            CreateUser("4", "wmanager", "wmanager@smis.com", "1", "Wholesale", "Manager", "+855123456792", hasher),
            CreateUser("5", "wstaff", "wstaff@smis.com", "1", "Wholesale", "Staff", "+855123456793", hasher),
            CreateUser("6", "wviewer", "wviewer@smis.com", "1", "Wholesale", "Viewer", "+8512345634366", hasher),
            CreateUser("7", "weditor", "weditor@smis.com", "1", "Wholesale", "Editor", "+855123456795", hasher),
            CreateUser("8", "wuser", "wuser@smis.com", "1", "Wholesale", "User", "+855123456796", hasher),
            
            // Retail Shop Users
            CreateUser("9", "radmin", "radmin@smis.com", "2", "Retail", "Admin", "+855123456797", hasher),
            CreateUser("10", "radministration", "radministration@smis.com", "2", "Retail", "Administration", "+855123456798", hasher),
            CreateUser("11", "rmanager", "rmanager@smis.com", "2", "Retail", "Manager", "+855123456799", hasher),
            CreateUser("12", "rstaff", "rstaff@smis.com", "2", "Retail", "Staff", "+855123456800", hasher),
            CreateUser("13", "rviewer", "rviewer@smis.com", "2", "Retail", "Viewer", "+855123456801", hasher),
            CreateUser("14", "reditor", "reditor@smis.com", "2", "Retail", "Editor", "+855123456802", hasher),
            CreateUser("15", "ruser", "ruser@smis.com", "2", "Retail", "User", "+855123456803", hasher)
        );
    }

    private static ApplicationUser CreateUser(string id, string userName, string email, string shopId, string? firstName, string? lastName, string? phoneNumber, PasswordHasher<ApplicationUser> hasher)
    {
        var user = ApplicationUser.Create(userName, email, shopId, firstName, lastName, phoneNumber);

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
        "1" => "Main Store",
        "2" => "Branch Store",
        "3" => "Warehouse",
        _ => null
    };
}
