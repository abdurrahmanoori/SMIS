using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class CustomerSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            // Main Store Customers
            CreateCustomer(SeedIds.Cust1,  "John",    SeedIds.Shop1, CustomerType.Individual, "Doe",       "Smith",     "john.doe@email.com",       "+855123456789", "123 Main St, Phnom Penh",   "TAX001", SeedIds.ProvinceKabul,    SeedIds.DistrictKabulCenter, true),
            CreateCustomer(SeedIds.Cust2,  "Jane",    SeedIds.Shop1, CustomerType.Individual, "Smith",     "Johnson",   "jane.smith@email.com",     "+855987654321", "456 Oak Ave, Phnom Penh",   "TAX002", SeedIds.ProvinceKabul,    SeedIds.DistrictKabulNorth,  true),
            CreateCustomer(SeedIds.Cust3,  "Michael", SeedIds.Shop1, CustomerType.Enterprise, "Brown",     "Davis",     "michael.brown@email.com",  "+855555123456", "789 Pine Rd, Phnom Penh",   null,     SeedIds.ProvinceHerat,    SeedIds.DistrictHeratCenter, true),

            // Branch Store Customers
            CreateCustomer(SeedIds.Cust4,  "Sarah",   SeedIds.Shop2, CustomerType.Individual, "Wilson",    "Miller",    "sarah.wilson@email.com",   "+855444987654", "321 Elm St, Siem Reap",     "TAX003", SeedIds.ProvinceKandahar, SeedIds.DistrictKabulCenter, true),
            CreateCustomer(SeedIds.Cust5,  "David",   SeedIds.Shop2, CustomerType.Individual, "Taylor",    "Anderson",  "david.taylor@email.com",   "+855333456789", "654 Maple Dr, Siem Reap",   null,     SeedIds.ProvinceKandahar, SeedIds.DistrictKabulNorth,  true),
            CreateCustomer(SeedIds.Cust6,  "Lisa",    SeedIds.Shop2, CustomerType.Enterprise, "Garcia",    "Martinez",  "lisa.garcia@email.com",    "+855222123456", "987 Cedar Ln, Siem Reap",   "TAX004", SeedIds.ProvinceBalkh,    SeedIds.DistrictHeratCenter, true),

            // Warehouse Customers
            CreateCustomer(SeedIds.Cust7,  "Robert",  SeedIds.Shop3, CustomerType.Individual, "Martinez",  "Rodriguez", "robert.martinez@email.com","+855111987654", "147 Birch St, Battambang",  null,     SeedIds.ProvinceKabul,    SeedIds.DistrictKabulCenter, true),
            CreateCustomer(SeedIds.Cust8,  "Emily",   SeedIds.Shop3, CustomerType.Individual, "Lopez",     "Hernandez", "emily.lopez@email.com",    "+855666456789", "258 Spruce Ave, Battambang","TAX005", SeedIds.ProvinceHerat,    SeedIds.DistrictKabulNorth,  true),
            CreateCustomer(SeedIds.Cust9,  "James",   SeedIds.Shop3, CustomerType.Enterprise, "Gonzalez",  "Perez",     "james.gonzalez@email.com", "+855777123456", "369 Fir Rd, Battambang",    null,     SeedIds.ProvinceKandahar, SeedIds.DistrictHeratCenter, true),
            CreateCustomer(SeedIds.Cust10, "Maria",   SeedIds.Shop3, CustomerType.Individual, "Rodriguez", "Sanchez",   "maria.rodriguez@email.com","+855888987654", "741 Ash Dr, Battambang",    "TAX006", SeedIds.ProvinceBalkh,    SeedIds.DistrictKabulCenter, true)
        );
    }

    private static Customer CreateCustomer(string id, string firstName, string shopId, CustomerType customerType, string? lastName, string? fatherName, string? email, string? phoneNumber, string? address, string? taxNumber, string? provinceId, string? districtId, bool isActive)
    {
        var customer = Customer.Create(firstName, shopId, customerType, lastName, fatherName, email, phoneNumber, address, taxNumber, provinceId, districtId, isActive);

        // Set ID and ShopName for seeding
        typeof(Customer).GetProperty(nameof(Customer.Id))!.SetValue(customer, id);
        typeof(Customer).GetProperty(nameof(Customer.ShopName))!.SetValue(customer, GetShopName(shopId));
        typeof(Customer).GetProperty(nameof(Customer.CreatedDate))!.SetValue(customer, DateTimeService.NowUtc);
        typeof(Customer).GetProperty(nameof(Customer.UpdatedDate))!.SetValue(customer, DateTimeService.NowUtc);
        typeof(Customer).GetProperty(nameof(Customer.LastModifiedUtc))!.SetValue(customer, DateTimeService.NowUtc);

        return customer;
    }

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        _ => null
    };
}
