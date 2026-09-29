using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class RoleComponentPermissionConfiguration : IEntityTypeConfiguration<RoleComponentPermission>
{
    public void Configure(
        EntityTypeBuilder<RoleComponentPermission> builder
    )
    {
        builder.ToTable("RoleComponentPermissions");
        builder.HasKey(permission => new { permission.RoleId, permission.ComponentId });

        builder.Property(permission => permission.RoleId)
            .HasMaxLength(450);

        builder.Property(permission => permission.ComponentId)
            .HasMaxLength(450);

        builder.HasOne(permission => permission.Role)
            .WithMany()
            .HasForeignKey(permission => permission.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(permission => permission.Component)
            .WithMany()
            .HasForeignKey(permission => permission.ComponentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
