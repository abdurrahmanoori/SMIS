using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(Supplier));
        builder.HasKey(supplier => supplier.Id);

        builder.Property(supplier => supplier.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(supplier => supplier.Name).IsRequired().HasMaxLength(200);
        builder.Property(supplier => supplier.PhoneNumber).HasMaxLength(50);
        builder.Property(supplier => supplier.Notes).HasMaxLength(500);
        builder.Property(supplier => supplier.IsActive).IsRequired();

        builder.HasOne(supplier => supplier.Shop)
            .WithMany()
            .HasForeignKey(supplier => supplier.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(supplier => new { supplier.ShopId, supplier.Name })
            .IsUnique()
            .HasFilter("[IsDeleted] = 0")
            .HasDatabaseName("UX_Supplier_ShopId_Name_Active");
    }
}

public sealed class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(PurchaseOrder));
        builder.HasKey(order => order.Id);

        builder.Property(order => order.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(order => order.SupplierId).IsRequired().HasMaxLength(450);
        builder.Property(order => order.ReferenceNumber).HasMaxLength(100);
        builder.Property(order => order.OrderedAtUtc).IsRequired();
        builder.Property(order => order.Status).IsRequired().HasConversion<string>().HasMaxLength(30);
        builder.Property(order => order.Notes).HasMaxLength(500);

        builder.HasOne(order => order.Shop)
            .WithMany()
            .HasForeignKey(order => order.ShopId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(order => order.Supplier)
            .WithMany(supplier => supplier.PurchaseOrders)
            .HasForeignKey(order => order.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(order => order.Lines)
            .WithOne(line => line.PurchaseOrder)
            .HasForeignKey(line => line.PurchaseOrderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(order => order.ShopId);
        builder.HasIndex(order => order.SupplierId);
        builder.HasIndex(order => order.OrderedAtUtc);
        builder.HasIndex(order => order.Status);
        builder.HasIndex(order => new { order.ShopId, order.ReferenceNumber });
    }
}

public sealed class PurchaseOrderLineConfiguration : IEntityTypeConfiguration<PurchaseOrderLine>
{
    public void Configure(EntityTypeBuilder<PurchaseOrderLine> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(PurchaseOrderLine));
        builder.HasKey(line => line.Id);

        builder.Property(line => line.PurchaseOrderId).IsRequired().HasMaxLength(450);
        builder.Property(line => line.ProductId).IsRequired().HasMaxLength(450);
        builder.Property(line => line.ProductUnitId).IsRequired().HasMaxLength(450);
        builder.Property(line => line.OrderedQuantityEntered).IsRequired().HasPrecision(18, 4);
        builder.Property(line => line.ReceivedQuantityEntered).IsRequired().HasPrecision(18, 4);
        builder.Property(line => line.ReturnedQuantityEntered).IsRequired().HasPrecision(18, 4);
        builder.Property(line => line.UnitCostBase).IsRequired();

        builder.HasOne(line => line.Product)
            .WithMany()
            .HasForeignKey(line => line.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(line => line.ProductUnit)
            .WithMany()
            .HasForeignKey(line => new { line.ProductUnitId, line.ProductId })
            .HasPrincipalKey(unit => new { unit.Id, unit.ProductId })
            .OnDelete(DeleteBehavior.Restrict);

        builder.Ignore(line => line.RemainingToReceiveQuantityEntered);
        builder.Ignore(line => line.NetReceivedQuantityEntered);

        builder.HasIndex(line => line.PurchaseOrderId);
        builder.HasIndex(line => line.ProductId);
        builder.HasIndex(line => line.ProductUnitId);
    }
}
