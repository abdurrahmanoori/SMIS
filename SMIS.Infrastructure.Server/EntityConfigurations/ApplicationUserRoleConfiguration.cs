using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class ApplicationUserRoleConfiguration : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(
            EntityTypeBuilder<ApplicationUserRole> builder
        )
        {
            builder.ToTable("AspNetUserRoles");

            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder.Property(ur => ur.UserId)
                .HasMaxLength(450);

            builder.Property(ur => ur.RoleId)
                .HasMaxLength(450);

            builder.Property(ur => ur.UserName)
                .HasMaxLength(256);

            builder.Property(ur => ur.RoleName)
                .HasMaxLength(256);

            builder.HasOne<ApplicationUser>()
                .WithMany()
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<ApplicationRole>()
                .WithMany()
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}