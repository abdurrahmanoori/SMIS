using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class ShopOwnerSeed
{
    public static void DataSeed(
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<ShopOwner>().HasData(
            CreateShopOwner(SeedIds.ShopOwner1, SeedIds.UserSuperAdmin, SeedIds.Shop1, "John", "Doe", "123456789",
                "+1234567890", "john.doe@example.com", "123 Main St", 100.0m, true),
            CreateShopOwner(SeedIds.ShopOwner2, SeedIds.UserMainAdmin, SeedIds.Shop2, "Jane", "Smith", "987654321",
                "+0987654321", "jane.smith@example.com", "456 Oak Ave", 75.0m, true),
            CreateShopOwner(SeedIds.ShopOwner3, SeedIds.UserMainManager, SeedIds.Shop3, "Bob", "Johnson", "555666777",
                "+1555666777", "bob.johnson@example.com", "789 Pine Rd", 50.0m, true),
            CreateShopOwner(SeedIds.ShopOwnerWasil, SeedIds.UserWasilAdmin, SeedIds.ShopWasil, "Wasil", "Admin",
                "123456789", "+1234567890", "wasil@wasilshop.com", "Kabul Center", 100.0m, true)
        );
    }

    private static ShopOwner CreateShopOwner(
        string id,
        string userId,
        string shopId,
        string firstName,
        string? lastName,
        string? nationalId,
        string? phoneNumber,
        string? email,
        string? address,
        decimal ownershipPercentage,
        bool isActive
    )
    {
        var owner = ShopOwner.Create(userId, shopId, firstName, lastName, phoneNumber, email, address,
            ownershipPercentage);

        // Set ID and additional properties for seeding
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.Id))!.SetValue(owner, id);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.ShopName))!.SetValue(owner, GetShopName(shopId));
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.StartDate))!.SetValue(owner, SeedIds.SeedTimestampUtc);
        owner.SetNationalIdCardNumber(nationalId);
        if (isActive) owner.Activate();
        else owner.Deactivate();
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.CreatedDate))!.SetValue(owner, SeedIds.SeedTimestampUtc);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.UpdatedDate))!.SetValue(owner, SeedIds.SeedTimestampUtc);
        typeof(ShopOwner).GetProperty(nameof(ShopOwner.LastModifiedUtc))!.SetValue(owner, SeedIds.SeedTimestampUtc);

        return owner;
    }

    private static string GetShopName(
        string shopId
    ) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        SeedIds.ShopWasil => "Wasil Shop",
        _ => "Unknown Shop"
    };
}