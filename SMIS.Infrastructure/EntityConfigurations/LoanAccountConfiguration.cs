using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations;

public class LoanAccountConfiguration : IEntityTypeConfiguration<LoanAccount>
{
    public void Configure(EntityTypeBuilder<LoanAccount> builder)
    {
        builder.ToTable(nameof(LoanAccount));

        builder.HasKey(l => l.Id);

        builder.Property(l => l.CustomerId)
            .IsRequired();

        builder.Property(l => l.CustomerName)
            .HasMaxLength(200);

        builder.Property(l => l.ShopId)
            .IsRequired();

        builder.Property(l => l.ShopName)
            .HasMaxLength(200);

        builder.Property(l => l.ProductId)
            .IsRequired();

        builder.Property(l => l.ProductName)
            .HasMaxLength(200);

        builder.Property(l => l.Quantity)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(l => l.UnitId)
            .IsRequired();

        builder.Property(l => l.UnitName)
            .HasMaxLength(100);

        builder.Property(l => l.PriceAtLoanTime)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(l => l.TotalAmount)
            .IsRequired();

        builder.Property(l => l.LoanDate)
            .IsRequired();

        builder.Property(l => l.Status)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(l => l.Notes)
            .HasMaxLength(500);

        builder.Property(l => l.IsActive)
            .IsRequired();

        builder.HasOne(l => l.Customer)
            .WithMany()
            .HasForeignKey(l => l.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(l => l.Shop)
            .WithMany()
            .HasForeignKey(l => l.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(l => l.Product)
            .WithMany()
            .HasForeignKey(l => l.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(l => l.UnitOfMeasure)
            .WithMany()
            .HasForeignKey(l => l.UnitId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(l => l.Payments)
            .WithOne(p => p.LoanAccount)
            .HasForeignKey(p => p.LoanAccountId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Ignore(l => l.PaidAmount);
        builder.Ignore(l => l.RemainingAmount);
    }
}
