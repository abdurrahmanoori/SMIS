using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Globalization;
using System.Security.Claims;
using System.Text;
using SMIS.Infrastructure.Server.DatabaseSeeders;
using SMIS.Infrastructure.Server.Services.Identity;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Domain.Services;

namespace SMIS.Api.Middleware;

/// <summary>
/// Development-only convenience middleware that injects a seeded SuperAdmin JWT when
/// a request has no Authorization header. It never replaces an explicitly supplied token
/// and is inactive outside the Development environment.
/// </summary>
public class DevelopmentJwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IWebHostEnvironment _environment;
    private readonly JwtSettings _jwtSettings;

    public DevelopmentJwtMiddleware(
        RequestDelegate next,
        IWebHostEnvironment environment,
        IOptions<JwtSettings> jwtSettings
    )
    {
        _next = next;
        _environment = environment;
        _jwtSettings = jwtSettings.Value;
    }

    public async Task InvokeAsync(
        HttpContext context,
        UserManager<ApplicationUser> userManager
    )
    {
        if (_environment.IsDevelopment() && !context.Request.Headers.ContainsKey("Authorization"))
        {
            // This keeps local Swagger/manual API calls convenient while still allowing
            // developers to test another user simply by supplying their own token.
            var user = await userManager.FindByIdAsync(SeedIds.UserSuperAdmin);
            if (user is not null)
            {
                var token = GenerateDevelopmentToken(user.SecurityVersion);
                context.Request.Headers.Append("Authorization", $"Bearer {token}");
            }
        }

        await _next(context);
    }

    private string GenerateDevelopmentToken(
        int securityVersion
    )
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, SeedIds.UserSuperAdmin),
            new Claim(ClaimTypes.Name, "superadmin"),
            new Claim(ClaimTypes.Email, "superadmin@mainstore.com"),
            new Claim(ClaimTypes.Role, "SuperAdmin"),
            new Claim("ShopId", SeedIds.Shop1.ToString()),
            new Claim(JwtClaimNames.AccessTokenVersion, JwtClaimNames.CurrentAccessTokenVersion),
            new Claim(
                JwtClaimNames.SecurityVersion,
                securityVersion.ToString(CultureInfo.InvariantCulture))
        };

        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTimeService.NowUtc.AddMinutes(_jwtSettings.AccessTokenLifetimeMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}