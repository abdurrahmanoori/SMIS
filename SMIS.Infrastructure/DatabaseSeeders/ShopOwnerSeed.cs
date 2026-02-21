using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class ShopOwnerSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShopOwner>().HasData(
            CreateShopOwner("1", "1", "1", "John", "Doe", "123456789", "+1234567890", "john.doe@example.com", "123 Main St", 100.0m, true),
            CreateShopOwner("2", "2", "2", "Jane", "Smith", "987654321", "+0987654321", "jane.smith@example.com", "456 Oak Ave", 75.0m, true),
            CreateShopOwner("3", "3", "3", "Bob", "Johnson", "555666777", "+1555666777", "bob.johnson@example.com", "789 Pine Rd", 50.0m, true)
        );
    }

    private static ShopOwner CreateShopOwner(string id, string userId, string shopId, string firstName, string? lastName, 
        string? nationalId, string? phoneNumber, string? email, string? address, decimal ownershipPercentage, bool isActive)
    {
        var owner = ShopOwner.Create(userId, shopId, firstName, lastName, phoneNumber, email, address, ownershipPercentage);

        // Set ID and additional properties for seeding
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.Id))!.SetValue(owner, id);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.ShopName))!.SetValue(owner, GetShopName(shopId));
        owner.SetNationalIdCardNumber(nationalId);
        if (isActive) owner.Activate(); else owner.Deactivate();
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.CreatedDate))!.SetValue(owner, DateTimeService.Now);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.UpdatedDate))!.SetValue(owner, DateTimeService.Now);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.LastModifiedUtc))!.SetValue(owner, DateTimeService.NowOffSet);

        return owner;
    }

    private static string GetShopName(string shopId) => shopId switch
    {
        "1" => "Main Store",
        "2" => "Branch Store", 
        "3" => "Warehouse",
        _ => "Unknown Shop"
    };
}