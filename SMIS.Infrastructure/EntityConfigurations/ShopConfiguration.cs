using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable(nameof(Shop));

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(s => s.Address)
                .HasMaxLength(500);

            builder.Property(s => s.PhoneNumber)
                .HasMaxLength(50);

            builder.Property(s => s.Email)
                .HasMaxLength(100);

            builder.Property(s => s.TaxNumber)
                .HasMaxLength(50);

            builder.Property(s => s.ShopType)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(s => s.IsActive)
                .IsRequired();
        }
    }
}
