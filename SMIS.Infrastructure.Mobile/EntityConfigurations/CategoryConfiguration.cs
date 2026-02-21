using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities;

namespace SMIS.Infrastructure.Mobile.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(e => e.Code)
            .HasMaxLength(50);
        
        builder.Property(e => e.Description)
            .HasMaxLength(500);
        
        builder.Property(e => e.IsActive)
            .IsRequired();
        
        builder.Property(e => e.ShopId)
            .IsRequired();
        
        builder.Property(e => e.IsSyncedToServer)
            .IsRequired()
            .HasDefaultValue(false);
        
        builder.Property(e => e.LastModifiedUtc)
            .IsRequired();
        
        builder.HasIndex(e => e.Code);
        builder.HasIndex(e => e.IsSyncedToServer);
        builder.HasIndex(e => e.ShopId);
        
        builder.Ignore(e => e.Shop);
        builder.Ignore(e => e.Products);
    }
}
