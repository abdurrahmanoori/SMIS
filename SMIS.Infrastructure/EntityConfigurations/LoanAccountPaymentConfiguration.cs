using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations;

public class LoanAccountPaymentConfiguration : IEntityTypeConfiguration<LoanAccountPayment>
{
    public void Configure(EntityTypeBuilder<LoanAccountPayment> builder)
    {
        builder.ToTable(nameof(LoanAccountPayment));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.LoanAccountId)
            .IsRequired();

        builder.Property(p => p.Amount)
            .IsRequired();

        builder.Property(p => p.PaymentDate)
            .IsRequired();

        builder.Property(p => p.PaymentMethod)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Notes)
            .HasMaxLength(500);

        builder.Property(p => p.IsActive)
            .IsRequired();

        builder.HasOne(p => p.LoanAccount)
            .WithMany(l => l.Payments)
            .HasForeignKey(p => p.LoanAccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
