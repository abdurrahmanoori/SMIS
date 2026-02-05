using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ShopOwnerConfiguration : IEntityTypeConfiguration<ShopOwner>
    {
        public void Configure(EntityTypeBuilder<ShopOwner> builder)
        {
            builder.ToTable(nameof(ShopOwner));

            builder.HasKey(so => so.Id);

            builder.Property(so => so.ApplicationUserId)
                .IsRequired();

            builder.Property(so => so.ShopId)
                .IsRequired();

            builder.Property(so => so.ShopName)
                .HasMaxLength(200);

            builder.Property(so => so.FirstName)
                .HasMaxLength(100);

            builder.Property(so => so.LastName)
                .HasMaxLength(100);

            builder.Property(so => so.NationalIdCardNumber)
                .HasMaxLength(50);

            builder.Property(so => so.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(so => so.Email)
                .HasMaxLength(256);

            builder.Property(so => so.Address)
                .HasMaxLength(500);

            builder.Property(so => so.OwnershipPercentage)
                .IsRequired()
                .HasPrecision(5, 2);

            builder.Property(so => so.StartDate)
                .IsRequired();

            builder.Property(so => so.EndDate);

            builder.Property(so => so.IsActive)
                .IsRequired();

            builder.Property(so => so.ProvinceId)
                .HasMaxLength(50);

            builder.Property(so => so.DistrictId)
                .HasMaxLength(50);

            // Foreign keys
            builder.HasOne(so => so.User)
                .WithMany()
                .HasForeignKey(so => so.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(so => so.Shop)
                .WithMany()
                .HasForeignKey(so => so.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(so => so.ApplicationUserId);
            builder.HasIndex(so => so.ShopId);
            builder.HasIndex(so => so.IsActive);
        }
    }
}