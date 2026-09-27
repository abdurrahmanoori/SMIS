using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Common.BaseAbstract;
using SMIS.Domain.Common.Interfaces;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

internal static class AuditableRelationshipConfigurationExtensions
{
    internal static void ConfigureAuditUserRelationships<TEntity>(
        this EntityTypeBuilder<TEntity> builder
    )
        where TEntity : class, IAuditableEntity
    {
        builder.Property(nameof(IAuditableEntity.CreatedBy))
            .HasMaxLength(450);

        builder.Property(nameof(IAuditableEntity.UpdatedBy))
            .HasMaxLength(450);

        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(nameof(IAuditableEntity.CreatedBy))
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(nameof(IAuditableEntity.UpdatedBy))
            .OnDelete(DeleteBehavior.Restrict);
    }

}