using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class SupplierPayableConfiguration : IEntityTypeConfiguration<SupplierPayable>
{
    public void Configure(EntityTypeBuilder<SupplierPayable> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(SupplierPayable));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.SupplierId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.PurchaseOrderId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.TotalAmount).IsRequired();
        builder.Property(x => x.CreditAmount).IsRequired();
        // Payment allocation and receipt/return handlers increment this version,
        // allowing EF Core to detect competing writes to the same payable.
        builder.Property(x => x.Version).IsConcurrencyToken();
        // Partial receipts accumulate on one payable per Purchase Order.
        builder.HasIndex(x => x.PurchaseOrderId).IsUnique();
        builder.HasIndex(x => new { x.ShopId, x.SupplierId });
        builder.HasOne(x => x.Supplier).WithMany().HasForeignKey(x => x.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.PurchaseOrder).WithOne().HasForeignKey<SupplierPayable>(x => x.PurchaseOrderId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Ignore(x => x.PaidAmount);
        builder.Ignore(x => x.SignedBalance);
        builder.Ignore(x => x.RemainingAmount);
        builder.Ignore(x => x.CreditDue);
    }
}

public sealed class SupplierPayableEntryConfiguration : IEntityTypeConfiguration<SupplierPayableEntry>
{
    public void Configure(EntityTypeBuilder<SupplierPayableEntry> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(SupplierPayableEntry));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.SupplierPayableId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.OperationId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.Kind).IsRequired().HasConversion<string>().HasMaxLength(30);
        builder.Property(x => x.Amount).IsRequired();
        builder.Property(x => x.OccurredAtUtc).IsRequired();
        // An inventory operation can have several lines but only one finance entry.
        builder.HasIndex(x => new { x.ShopId, x.OperationId }).IsUnique();
        builder.HasIndex(x => x.SupplierPayableId);
        builder.HasOne(x => x.Payable).WithMany(x => x.Entries)
            .HasForeignKey(x => x.SupplierPayableId).OnDelete(DeleteBehavior.Restrict);
    }
}

public sealed class SupplierPaymentConfiguration : IEntityTypeConfiguration<SupplierPayment>
{
    public void Configure(EntityTypeBuilder<SupplierPayment> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(SupplierPayment));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.SupplierId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.Amount).IsRequired();
        builder.Property(x => x.PaidAtUtc).IsRequired();
        builder.Property(x => x.PaymentMethod).IsRequired().HasMaxLength(50);
        builder.Property(x => x.ReferenceNumber).HasMaxLength(100);
        builder.Property(x => x.Notes).HasMaxLength(500);
        builder.HasIndex(x => new { x.ShopId, x.SupplierId, x.PaidAtUtc });
        builder.HasOne(x => x.Supplier).WithMany().HasForeignKey(x => x.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public sealed class SupplierPaymentAllocationConfiguration : IEntityTypeConfiguration<SupplierPaymentAllocation>
{
    public void Configure(EntityTypeBuilder<SupplierPaymentAllocation> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(SupplierPaymentAllocation));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ShopId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.SupplierPaymentId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.SupplierPayableId).IsRequired().HasMaxLength(450);
        builder.Property(x => x.Amount).IsRequired();
        builder.HasIndex(x => new { x.SupplierPaymentId, x.SupplierPayableId }).IsUnique();
        builder.HasIndex(x => x.SupplierPayableId);
        builder.HasOne(x => x.Payment).WithMany(x => x.Allocations)
            .HasForeignKey(x => x.SupplierPaymentId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Payable).WithMany(x => x.Allocations)
            .HasForeignKey(x => x.SupplierPayableId).OnDelete(DeleteBehavior.Restrict);
    }
}
