using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public class LocalizedTextConfiguration : IEntityTypeConfiguration<LocalizedText>
{
    public void Configure(EntityTypeBuilder<LocalizedText> builder)
    {
        builder.ToTable(nameof(LocalizedText));
        builder.HasKey(x => x.Id);

        builder.Property(x => x.DefaultValue)
            .IsRequired()
            .HasMaxLength(1000);

        builder.HasMany(x => x.Translations)
            .WithOne(x => x.LocalizedText)
            .HasForeignKey(x => x.LocalizedTextId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
