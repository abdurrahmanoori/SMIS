using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public class LoanAccountConfiguration : IEntityTypeConfiguration<LoanAccount>
{
    public void Configure(
        EntityTypeBuilder<LoanAccount> builder
    )
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(LoanAccount));

        builder.HasKey(loan => loan.Id);

        builder.Property(loan => loan.SaleId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(loan => loan.CustomerId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(loan => loan.CustomerName)
            .HasMaxLength(200);
        builder.Property(loan => loan.ShopId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(loan => loan.ShopName)
            .HasMaxLength(200);
        builder.Property(loan => loan.TotalAmount)
            .IsRequired();
        builder.Property(loan => loan.CreditAmount)
            .IsRequired();
        builder.Property(loan => loan.LoanDate)
            .IsRequired();
        builder.Property(loan => loan.Status)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(50);
        builder.Property(loan => loan.Notes)
            .HasMaxLength(500);
        builder.Property(loan => loan.IsActive)
            .IsRequired();

        // One credit sale can create only one receivable.
        builder.HasIndex(loan => loan.SaleId)
            .IsUnique();

        builder.HasOne(loan => loan.Sale)
            .WithOne(sale => sale.Receivable)
            .HasForeignKey<LoanAccount>(loan => loan.SaleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(loan => loan.Customer)
            .WithMany()
            .HasForeignKey(loan => loan.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(loan => loan.Shop)
            .WithMany()
            .HasForeignKey(loan => loan.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(loan => loan.Payments)
            .WithOne(payment => payment.LoanAccount)
            .HasForeignKey(payment => payment.LoanAccountId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Ignore(loan => loan.PaidAmount);
        builder.Ignore(loan => loan.NetReceivableAmount);
        builder.Ignore(loan => loan.RemainingAmount);
        builder.Ignore(loan => loan.OverpaidAmount);
    }
}