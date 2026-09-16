using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class IdempotencyRecordConfiguration : IEntityTypeConfiguration<IdempotencyRecord>
{
    public void Configure(EntityTypeBuilder<IdempotencyRecord> builder)
    {
        builder.ConfigureAuditUserRelationships();
        builder.ToTable(nameof(IdempotencyRecord));

        builder.HasKey(record => record.Id);
        builder.Property(record => record.ActorId).IsRequired().HasMaxLength(450);
        builder.Property(record => record.Scope).IsRequired().HasMaxLength(100);
        builder.Property(record => record.Key).IsRequired().HasMaxLength(200);

        builder.HasIndex(record => new { record.ActorId, record.Scope, record.Key })
            .IsUnique()
            .HasDatabaseName("UX_IdempotencyRecord_Actor_Scope_Key");
    }
}
