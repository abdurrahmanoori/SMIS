using Microsoft.EntityFrameworkCore;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.DatabaseSeeders;

public static class LoanAccountSeed
{
    public static void DataSeed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoanAccount>().HasData(
            CreateLoanAccount("1", "1", "1", "1", 10, "3", 5000, 50000, DateTime.UtcNow, DateTime.UtcNow.AddDays(30), "First loan for Coca Cola", true),
            CreateLoanAccount("2", "2", "1", "4", 5, "3", 5000, 25000, DateTime.UtcNow, DateTime.UtcNow.AddDays(15), "Oreo biscuits loan", true),
            CreateLoanAccount("3", "1", "2", "7", 20, "1", 5000, 100000, DateTime.UtcNow, null, "Notebook purchase", true)
        );
    }

    private static LoanAccount CreateLoanAccount(string id, string customerId, string shopId, string productId, decimal quantity, string unitId, decimal priceAtLoanTime, long totalAmount, DateTime loanDate, DateTime? dueDate, string? notes, bool isActive)
    {
        var loanAccount = LoanAccount.Create(customerId, shopId, productId, quantity, unitId, priceAtLoanTime, totalAmount, dueDate, notes);

        typeof(LoanAccount).GetProperty(nameof(LoanAccount.Id))!.SetValue(loanAccount, id);
        
        loanAccount.CustomerName = customerId == "1" ? "John Doe" : customerId == "2" ? "Jane Smith" : null;
        loanAccount.ShopName = shopId == "1" ? "Main Wholesale Shop" : shopId == "2" ? "Downtown Retail" : null;
        loanAccount.ProductName = productId == "1" ? "Coca Cola" : productId == "4" ? "Oreo Biscuit" : productId == "7" ? "Notebook A4" : null;
        loanAccount.UnitName = unitId == "3" ? "Bottle" : unitId == "1" ? "Piece" : null;
        
        var loanDateProp = typeof(LoanAccount).GetProperty(nameof(LoanAccount.LoanDate));
        if (loanDateProp != null)
        {
            loanDateProp.SetValue(loanAccount, loanDate);
        }
        if (!isActive) loanAccount.Deactivate();

        return loanAccount;
    }
}
