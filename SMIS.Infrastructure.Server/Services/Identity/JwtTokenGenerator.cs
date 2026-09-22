using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.Services.Identity;

/// <summary>
/// JWT implementation of ITokenGenerator.
/// Registered in SMIS.Api and any host that requires JWT-based authentication.
/// </summary>
public class JwtTokenGenerator : ITokenGenerator
{
    private readonly IConfiguration _configuration;

    public JwtTokenGenerator(
        IConfiguration configuration
    )
    {
        _configuration = configuration;
    }

    public string Generate(
        ApplicationUser user,
        IList<string> roles,
        string? shopIdOverride = null
    )
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id),
            new(ClaimTypes.Email, user.Email!),
            new(ClaimTypes.Name, user.UserName!)
        };

        var effectiveShopId = !string.IsNullOrWhiteSpace(shopIdOverride)
            ? shopIdOverride
            : user.ShopId;

        if (!string.IsNullOrEmpty(effectiveShopId))
            // CurrentUser and DbContext tenant filters read this exact claim name.
            claims.Add(new Claim(nameof(ApplicationUser.ShopId), effectiveShopId));

        if (!string.IsNullOrEmpty(user.LanguageId))
            // Language preference travels with the token so request services do not
            // need an extra user lookup merely to resolve the preferred language.
            claims.Add(new Claim(nameof(ApplicationUser.LanguageId), user.LanguageId));

        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        var token = new JwtSecurityToken(
            issuer: _configuration["JwtSettings:Issuer"],
            audience: _configuration["JwtSettings:Audience"],
            claims: claims,
            expires: DateTimeService.NowUtc.AddMonths(2),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}