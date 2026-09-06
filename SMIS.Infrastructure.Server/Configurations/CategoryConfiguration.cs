using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Server.Configurations;

public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(category => category.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(category => category.Code)
            .HasMaxLength(50);

        builder.Property(category => category.Description)
            .HasMaxLength(500);

        builder.Property(category => category.ShopId)
            .IsRequired();

        builder.Property(category => category.ClientCreatedBy)
            .HasMaxLength(450);

        builder.Property(category => category.ClientModifiedBy)
            .HasMaxLength(450);
    }
}
