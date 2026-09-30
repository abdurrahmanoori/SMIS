using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class RoleTaskPermissionConfiguration : IEntityTypeConfiguration<RoleTaskPermission>
{
    public void Configure(
        EntityTypeBuilder<RoleTaskPermission> builder
    )
    {
        builder.ToTable("RoleTaskPermissions");
        builder.HasKey(permission => new { permission.RoleId, permission.TaskId });

        builder.Property(permission => permission.RoleId).HasMaxLength(450);
        builder.Property(permission => permission.TaskId).HasMaxLength(450);

        builder.HasOne(permission => permission.Role)
            .WithMany()
            .HasForeignKey(permission => permission.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(permission => permission.Task)
            .WithMany()
            .HasForeignKey(permission => permission.TaskId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
