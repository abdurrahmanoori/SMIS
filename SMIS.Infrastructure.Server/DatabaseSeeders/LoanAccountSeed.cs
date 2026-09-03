using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.DatabaseSeeders;

public static class LoanAccountSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        var now = DateTimeService.NowUtc;
        modelBuilder.Entity<LoanAccount>().HasData(
            // Main Store loans
            CreateLoanAccount(SeedIds.Loan1,  SeedIds.Cust1,  SeedIds.Shop1, SeedIds.ProdCocaCola,   10,  SeedIds.UnitBottle,   5000, 50000,  now.AddDays(-30), now.AddDays(30),  "Coca Cola loan for John",    true),
            CreateLoanAccount(SeedIds.Loan2,  SeedIds.Cust2,  SeedIds.Shop1, SeedIds.ProdOreo,        5,  SeedIds.UnitPack,     4000, 20000,  now.AddDays(-15), now.AddDays(15),  "Oreo biscuits for Jane",     true),
            CreateLoanAccount(SeedIds.Loan3,  SeedIds.Cust3,  SeedIds.Shop1, SeedIds.ProdNotebook,   20,  SeedIds.UnitPiece,    3000, 60000,  now.AddDays(-10), now.AddDays(20),  "Notebooks for Michael",      true),
            CreateLoanAccount(SeedIds.Loan4,  SeedIds.Cust1,  SeedIds.Shop1, SeedIds.ProdCookingOil, 15,  SeedIds.UnitBottle,   8000, 120000, now.AddDays(-5),  now.AddDays(45),  "Cooking oil bulk order",     true),

            // Branch Store loans
            CreateLoanAccount(SeedIds.Loan5,  SeedIds.Cust4,  SeedIds.Shop2, SeedIds.ProdPepsi,      24,  SeedIds.UnitBottle,   4500, 108000, now.AddDays(-20), now.AddDays(10),  "Pepsi for Sarah",            true),
            CreateLoanAccount(SeedIds.Loan6,  SeedIds.Cust5,  SeedIds.Shop2, SeedIds.ProdBluePen,    50,  SeedIds.UnitPiece,    500,  25000,  now.AddDays(-12), now.AddDays(18),  "Blue pens for David",        true),
            CreateLoanAccount(SeedIds.Loan7,  SeedIds.Cust6,  SeedIds.Shop2, SeedIds.ProdRice,       100, SeedIds.UnitKilogram, 2000, 200000, now.AddDays(-25), null,             "Rice bulk purchase",         true),

            // Warehouse loans
            CreateLoanAccount(SeedIds.Loan8,  SeedIds.Cust7,  SeedIds.Shop3, SeedIds.ProdMineralWater,48, SeedIds.UnitBottle,   3000, 144000, now.AddDays(-18), now.AddDays(12),  "Mineral water for Robert",   true),
            CreateLoanAccount(SeedIds.Loan9,  SeedIds.Cust8,  SeedIds.Shop3, SeedIds.ProdNoodles,    30,  SeedIds.UnitPack,     1500, 45000,  now.AddDays(-8),  now.AddDays(22),  "Instant noodles for Emily",  true),
            CreateLoanAccount(SeedIds.Loan10, SeedIds.Cust9,  SeedIds.Shop3, SeedIds.ProdUsbCable,   100, SeedIds.UnitPiece,    1000, 100000, now.AddDays(-3),  now.AddDays(27),  "USB cables for James",       true)
        );
    }

    private static LoanAccount CreateLoanAccount(string id, string customerId, string shopId, string productId, decimal quantity, string unitId, decimal priceAtLoanTime, long totalAmount, DateTime loanDate, DateTime? dueDate, string? notes, bool isActive)
    {
        var loanAccount = LoanAccount.Create(customerId, shopId, productId, quantity, unitId, priceAtLoanTime, totalAmount, dueDate, notes);

        typeof(LoanAccount).GetProperty(nameof(LoanAccount.Id))!.SetValue(loanAccount, id);
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.CustomerName))!.SetValue(loanAccount, GetCustomerName(customerId));
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.ShopName))!.SetValue(loanAccount, GetShopName(shopId));
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.ProductName))!.SetValue(loanAccount, GetProductName(productId));
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.UnitName))!.SetValue(loanAccount, GetUnitName(unitId));

        var loanDateProp = typeof(LoanAccount).GetProperty(nameof(LoanAccount.LoanDate));
        if (loanDateProp != null)
        {
            loanDateProp.SetValue(loanAccount, loanDate);
        }
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.CreatedDate))!.SetValue(loanAccount, DateTimeService.NowUtc);
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.UpdatedDate))!.SetValue(loanAccount, DateTimeService.NowUtc);
        typeof(LoanAccount).GetProperty(nameof(LoanAccount.LastModifiedUtc))!.SetValue(loanAccount, DateTimeService.NowUtc);
        if (!isActive) loanAccount.Deactivate();

        return loanAccount;
    }

    private static string? GetCustomerName(string customerId) => customerId switch
    {
        SeedIds.Cust1 => "John",
        SeedIds.Cust2 => "Jane",
        SeedIds.Cust3 => "Michael",
        SeedIds.Cust4 => "Sarah",
        SeedIds.Cust5 => "David",
        SeedIds.Cust6 => "Lisa",
        SeedIds.Cust7 => "Robert",
        SeedIds.Cust8 => "Emily",
        SeedIds.Cust9 => "James",
        _ => null
    };

    private static string? GetShopName(string shopId) => shopId switch
    {
        SeedIds.Shop1 => "Main Store",
        SeedIds.Shop2 => "Branch Store",
        SeedIds.Shop3 => "Warehouse",
        _ => null
    };

    private static string? GetProductName(string productId) => productId switch
    {
        SeedIds.ProdCocaCola     => "Coca Cola 500ml",
        SeedIds.ProdPepsi        => "Pepsi 500ml",
        SeedIds.ProdMineralWater => "Mineral Water 1L",
        SeedIds.ProdOreo         => "Oreo Biscuits",
        SeedIds.ProdNoodles      => "Instant Noodles",
        SeedIds.ProdNotebook     => "A4 Notebook",
        SeedIds.ProdBluePen      => "Blue Pen",
        SeedIds.ProdCookingOil   => "Cooking Oil 1L",
        SeedIds.ProdRice         => "Rice 1kg",
        SeedIds.ProdUsbCable     => "USB Cable",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        SeedIds.UnitPiece    => "Piece",
        SeedIds.UnitBottle   => "Bottle",
        SeedIds.UnitPack     => "Pack",
        SeedIds.UnitKilogram => "Kilogram",
        _ => null
    };
}
