using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SMIS.Domain.Entities.Identity.Entity;
using System.Security.Claims;

namespace SMIS.Infrastructure.Server.Services.Identity;

/// <summary>
/// Extends the default claims principal factory to include custom user claims
/// (ShopId, LanguageId) in the cookie identity issued by SignInManager.
/// This ensures ICurrentUser.GetShopId() resolves correctly in Blazor Server.
/// </summary>
public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, ApplicationRole>
{
    public ApplicationUserClaimsPrincipalFactory(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IOptions<IdentityOptions> options)
        : base(userManager, roleManager, options) { }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);

        identity.AddClaim(new Claim(nameof(ApplicationUser.ShopId), user.ShopId));
        identity.AddClaim(new Claim(nameof(ApplicationUser.LanguageId), user.LanguageId));

        return identity;
    }
}
