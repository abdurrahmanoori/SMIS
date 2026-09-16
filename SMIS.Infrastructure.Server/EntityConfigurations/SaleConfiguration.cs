using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(
        EntityTypeBuilder<Sale> builder
    )
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(Sale));

        builder.HasKey(sale => sale.Id);

        builder.Property(sale => sale.ShopId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(sale => sale.CustomerId)
            .HasMaxLength(450);
        builder.Property(sale => sale.SaleDateUtc)
            .IsRequired();
        builder.Property(sale => sale.PaymentType)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(20);
        builder.Property(sale => sale.TotalAmount)
            .IsRequired();
        builder.Property(sale => sale.Notes)
            .HasMaxLength(500);

        builder.HasOne(sale => sale.Shop)
            .WithMany()
            .HasForeignKey(sale => sale.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(sale => sale.Customer)
            .WithMany()
            .HasForeignKey(sale => sale.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(sale => sale.Lines)
            .WithOne(line => line.Sale)
            .HasForeignKey(line => line.SaleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(sale => sale.ShopId);
        builder.HasIndex(sale => sale.CustomerId);
        builder.HasIndex(sale => sale.SaleDateUtc);
        builder.HasIndex(sale => sale.PaymentType);
    }
}