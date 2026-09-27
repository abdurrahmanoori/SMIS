using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.EntityConfigurations
{
    public class UnitOfMeasureConfiguration : IEntityTypeConfiguration<UnitOfMeasure>
    {
        public void Configure(
            EntityTypeBuilder<UnitOfMeasure> builder
        )
        {
            builder.ConfigureAuditUserRelationships();
            builder.ToTable(nameof(UnitOfMeasure));

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Symbol)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Description)
                .HasMaxLength(500);

            builder.HasIndex(u => u.Name)
                .IsUnique()
                .HasFilter("[IsDeleted] = 0")
                .HasDatabaseName("UX_UnitOfMeasure_Name_Active");

            builder.HasIndex(u => u.Symbol)
                .IsUnique()
                .HasFilter("[IsDeleted] = 0 AND [Symbol] IS NOT NULL")
                .HasDatabaseName("UX_UnitOfMeasure_Symbol_Active");
        }
    }
}