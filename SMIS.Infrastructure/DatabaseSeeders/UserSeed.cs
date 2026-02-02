using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class UserSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>().HasData(
            CreateUser("1", "admin", "admin@smis.com", "1", "System", "Administrator", "+855123456789"),
            CreateUser("2", "manager1", "manager1@smis.com", "1", "John", "Manager", "+855123456790"),
            CreateUser("3", "staff1", "staff1@smis.com", "1", "Jane", "Staff", "+855123456791"),
            CreateUser("4", "manager2", "manager2@smis.com", "2", "Mike", "Manager", "+855123456792"),
            CreateUser("5", "staff2", "staff2@smis.com", "2", "Sarah", "Staff", "+855123456793"),
            CreateUser("6", "warehouse1", "warehouse1@smis.com", "3", "David", "Keeper", "+855123456794")
        );
    }

    private static ApplicationUser CreateUser(string id, string userName, string email, string shopId, string? firstName, string? lastName, string? phoneNumber)
    {
        var user = ApplicationUser.Create(userName, email, shopId, firstName, lastName, phoneNumber);

        // Set ID and ShopName for seeding
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.Id))!.SetValue(user, id);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ShopName))!.SetValue(user, GetShopName(shopId));
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.EmailConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PhoneNumberConfirmed))!.SetValue(user, true);
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.SecurityStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.ConcurrencyStamp))!.SetValue(user, Guid.NewGuid().ToString());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedUserName))!.SetValue(user, userName.ToUpper());
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.NormalizedEmail))!.SetValue(user, email.ToUpper());
        
        // Set password hash for "Password123!"
        typeof(ApplicationUser).GetProperty(nameof(ApplicationUser.PasswordHash))!.SetValue(user, "AQAAAAIAAYagAAAAEJ8VwpZajvQzWf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8vQf8=");

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
