using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
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
                //.IsRequired()
                .HasMaxLength(500);

            builder.Property(s => s.PhoneNumber)
                //.IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Email)
              //  .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.TaxNumber)
               // .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.ShopType)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(s => s.IsActive)
                .IsRequired();
        }
    }
}
