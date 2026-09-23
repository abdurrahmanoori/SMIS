using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class SaleLineConfiguration : IEntityTypeConfiguration<SaleLine>
{
    public void Configure(
        EntityTypeBuilder<SaleLine> builder
    )
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(SaleLine));

        builder.HasKey(line => line.Id);

        builder.Property(line => line.SaleId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(line => line.ProductId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(line => line.ProductUnitId)
            .IsRequired()
            .HasMaxLength(450);
        builder.Property(line => line.QuantityEntered)
            .IsRequired()
            .HasPrecision(18, 4);
        builder.Property(line => line.ReturnedQuantityEntered)
            .IsRequired()
            .HasPrecision(18, 4);
        builder.Property(line => line.UnitPrice)
            .IsRequired();
        builder.Property(line => line.LineTotal)
            .IsRequired();

        builder.HasOne(line => line.Product)
            .WithMany()
            .HasForeignKey(line => line.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        // Composite FK guarantees the ProductUnit belongs to the same Product captured
        // by this line; package conversion identity cannot drift across products.
        builder.HasOne(line => line.ProductUnit)
            .WithMany()
            .HasForeignKey(line => new { line.ProductUnitId, line.ProductId })
            .HasPrincipalKey(productUnit => new { productUnit.Id, productUnit.ProductId })
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(line => line.SaleId);
        builder.HasIndex(line => line.ProductId);
        builder.HasIndex(line => line.ProductUnitId);
    }
}