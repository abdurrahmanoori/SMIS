using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class CustomerSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            // Main Store Customers
            CreateCustomer("1", "John", "Doe", "1", "Smith", "john.doe@email.com", "+855123456789", "123 Main St, Phnom Penh", "TAX001", "1", "1", true),
            CreateCustomer("2", "Jane", "Smith", "1", "Johnson", "jane.smith@email.com", "+855987654321", "456 Oak Ave, Phnom Penh", "TAX002", "1", "2", true),
            CreateCustomer("3", "Michael", "Brown", "1", "Davis", "michael.brown@email.com", "+855555123456", "789 Pine Rd, Phnom Penh", null, "2", "3", true),

            // Branch Store Customers
            CreateCustomer("4", "Sarah", "Wilson", "2", "Miller", "sarah.wilson@email.com", "+855444987654", "321 Elm St, Siem Reap", "TAX003", "3", "1", true),
            CreateCustomer("5", "David", "Taylor", "2", "Anderson", "david.taylor@email.com", "+855333456789", "654 Maple Dr, Siem Reap", null, "3", "2", true),
            CreateCustomer("6", "Lisa", "Garcia", "2", "Martinez", "lisa.garcia@email.com", "+855222123456", "987 Cedar Ln, Siem Reap", "TAX004", "4", "3", true),

            // Warehouse Customers
            CreateCustomer("7", "Robert", "Martinez", "3", "Rodriguez", "robert.martinez@email.com", "+855111987654", "147 Birch St, Battambang", null, "1", "1", true),
            CreateCustomer("8", "Emily", "Lopez", "3", "Hernandez", "emily.lopez@email.com", "+855666456789", "258 Spruce Ave, Battambang", "TAX005", "2", "2", true),
            CreateCustomer("9", "James", "Gonzalez", "3", "Perez", "james.gonzalez@email.com", "+855777123456", "369 Fir Rd, Battambang", null, "3", "3", true),
            CreateCustomer("10", "Maria", "Rodriguez", "3", "Sanchez", "maria.rodriguez@email.com", "+855888987654", "741 Ash Dr, Battambang", "TAX006", "4", "1", true)
        );
    }

    private static Customer CreateCustomer(string id, string firstName, string? lastName, string shopId, string? fatherName, string? email, string? phoneNumber, string? address, string? taxNumber, string? provinceId, string? districtId, bool isActive)
    {
        var customer = Customer.Create(firstName, shopId, lastName, fatherName, email, phoneNumber, address, taxNumber, provinceId, districtId, isActive);

        // Set ID and ShopName for seeding
        typeof(Customer).GetProperty(nameof(Customer.Id))!.SetValue(customer, id);
        typeof(Customer).GetProperty(nameof(Customer.ShopName))!.SetValue(customer, GetShopName(shopId));

        return customer;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        "1" => "Main Store",
        "2" => "Branch Store", 
        "3" => "Warehouse",
        _ => null
    };
}