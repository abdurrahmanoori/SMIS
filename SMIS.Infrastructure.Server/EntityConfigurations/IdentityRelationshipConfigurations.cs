using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Infrastructure.Server.EntityConfigurations;

public sealed class IdentityRoleClaimConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<string>>
{
    public void Configure(
        EntityTypeBuilder<IdentityRoleClaim<string>> builder
    )
    {
        builder.HasOne<ApplicationRole>()
            .WithMany()
            .HasForeignKey(claim => claim.RoleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public sealed class IdentityUserClaimConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
{
    public void Configure(
        EntityTypeBuilder<IdentityUserClaim<string>> builder
    )
    {
        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(claim => claim.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public sealed class IdentityUserLoginConfiguration : IEntityTypeConfiguration<IdentityUserLogin<string>>
{
    public void Configure(
        EntityTypeBuilder<IdentityUserLogin<string>> builder
    )
    {
        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(login => login.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

public sealed class IdentityUserTokenConfiguration : IEntityTypeConfiguration<IdentityUserToken<string>>
{
    public void Configure(
        EntityTypeBuilder<IdentityUserToken<string>> builder
    )
    {
        builder.HasOne<ApplicationUser>()
            .WithMany()
            .HasForeignKey(token => token.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}