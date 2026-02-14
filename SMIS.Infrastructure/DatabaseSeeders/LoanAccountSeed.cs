using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class LoanAccountSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoanAccount>().HasData(
            // Main Store loans
            CreateLoanAccount("1", "1", "1", "1", 10, "2", 5000, 50000, DateTime.UtcNow.AddDays(-30), DateTime.UtcNow.AddDays(30), "Coca Cola loan for John", true),
            CreateLoanAccount("2", "2", "1", "4", 5, "3", 4000, 20000, DateTime.UtcNow.AddDays(-15), DateTime.UtcNow.AddDays(15), "Oreo biscuits for Jane", true),
            CreateLoanAccount("3", "3", "1", "7", 20, "1", 3000, 60000, DateTime.UtcNow.AddDays(-10), DateTime.UtcNow.AddDays(20), "Notebooks for Michael", true),
            CreateLoanAccount("4", "1", "1", "10", 15, "2", 8000, 120000, DateTime.UtcNow.AddDays(-5), DateTime.UtcNow.AddDays(45), "Cooking oil bulk order", true),
            
            // Branch Store loans
            CreateLoanAccount("5", "4", "2", "2", 24, "2", 4500, 108000, DateTime.UtcNow.AddDays(-20), DateTime.UtcNow.AddDays(10), "Pepsi for Sarah", true),
            CreateLoanAccount("6", "5", "2", "8", 50, "1", 500, 25000, DateTime.UtcNow.AddDays(-12), DateTime.UtcNow.AddDays(18), "Blue pens for David", true),
            CreateLoanAccount("7", "6", "2", "11", 100, "7", 2000, 200000, DateTime.UtcNow.AddDays(-25), null, "Rice bulk purchase", true),
            
            // Warehouse loans
            CreateLoanAccount("8", "7", "3", "3", 48, "2", 3000, 144000, DateTime.UtcNow.AddDays(-18), DateTime.UtcNow.AddDays(12), "Mineral water for Robert", true),
            CreateLoanAccount("9", "8", "3", "6", 30, "3", 1500, 45000, DateTime.UtcNow.AddDays(-8), DateTime.UtcNow.AddDays(22), "Instant noodles for Emily", true),
            CreateLoanAccount("10", "9", "3", "15", 100, "1", 1000, 100000, DateTime.UtcNow.AddDays(-3), DateTime.UtcNow.AddDays(27), "USB cables for James", true)
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
        if (!isActive) loanAccount.Deactivate();

        return loanAccount;
    }

    private static string? GetCustomerName(string customerId) => customerId switch
    {
        "1" => "John",
        "2" => "Jane",
        "3" => "Michael",
        "4" => "Sarah",
        "5" => "David",
        "6" => "Lisa",
        "7" => "Robert",
        "8" => "Emily",
        "9" => "James",
        _ => null
    };

    private static string? GetShopName(string shopId) => shopId switch
    {
        "1" => "Main Store",
        "2" => "Branch Store",
        "3" => "Warehouse",
        _ => null
    };

    private static string? GetProductName(string productId) => productId switch
    {
        "1" => "Coca Cola 500ml",
        "2" => "Pepsi 500ml",
        "3" => "Mineral Water 1L",
        "4" => "Oreo Biscuits",
        "6" => "Instant Noodles",
        "7" => "A4 Notebook",
        "8" => "Blue Pen",
        "10" => "Cooking Oil 1L",
        "11" => "Rice 1kg",
        "15" => "USB Cable",
        _ => null
    };

    private static string? GetUnitName(string unitId) => unitId switch
    {
        "1" => "Piece",
        "2" => "Bottle",
        "3" => "Pack",
        "7" => "Kilogram",
        _ => null
    };
}
