using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class UnitOfMeasureConfiguration : IEntityTypeConfiguration<UnitOfMeasure>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasure> builder)
        {
            builder.ToTable(nameof(UnitOfMeasure));

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Symbol)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Description)
                .HasMaxLength(500);

            builder.Property(u => u.ShopId)
                .IsRequired();

            builder.HasOne(u => u.Shop)
                .WithMany()
                .HasForeignKey(u => u.ShopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
