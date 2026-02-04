using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasMaxLength(50);

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.Property(e => e.FatherName).HasMaxLength(100);
            builder.Property(e => e.ShopId).IsRequired().HasMaxLength(50);
            builder.Property(e => e.ShopName).HasMaxLength(200);
            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.PhoneNumber).HasMaxLength(20);
            builder.Property(e => e.Address).HasMaxLength(500);
            builder.Property(e => e.TaxNumber).HasMaxLength(20);
            builder.Property(e => e.ProvinceId).HasMaxLength(50);
            builder.Property(e => e.DistrictId).HasMaxLength(50);

            builder.HasIndex(e => e.Email);
            builder.HasIndex(e => e.PhoneNumber);
            builder.HasIndex(e => e.TaxNumber);
            builder.HasIndex(e => e.ShopId);
            builder.HasIndex(e => e.IsActive);
            builder.HasIndex(e => e.IsDeleted);

            builder.HasOne(e => e.Shop)
                .WithMany()
                .HasForeignKey(e => e.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Province)
                .WithMany()
                .HasForeignKey(e => e.ProvinceId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.District)
                .WithMany()
                .HasForeignKey(e => e.DistrictId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}