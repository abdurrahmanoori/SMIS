using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                .HasMaxLength(100);

            builder.Property(u => u.LastName)
                .HasMaxLength(100);

            builder.Property(u => u.ShopId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.ShopName)
                .HasMaxLength(200);

            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            // Foreign key relationship
            builder.HasOne(u => u.Shop)
                .WithMany() // Shop has commented navigation to Users
                .HasForeignKey(u => u.ShopId)
                .OnDelete(DeleteBehavior.Restrict);

            // Indexes
            builder.HasIndex(u => u.ShopId);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.UserName).IsUnique();
        }
    }
}