using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMIS.Application.DTO.Auth;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities.Identity.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Security.Claims;
using SMIS.Domain.Services;

namespace SMIS.Infrastructure.Server.Services.Identity;

/// <summary>
/// Issues short-lived JWTs used only to authenticate a signed-in SMIS user to
/// PowerSync. The normal SMIS access token remains the app-to-API credential.
/// </summary>
public sealed class PowerSyncTokenGenerator : IPowerSyncTokenGenerator
{
    private readonly IConfiguration _configuration;

    public PowerSyncTokenGenerator(
        IConfiguration configuration
    )
    {
        _configuration = configuration;
    }

    public PowerSyncCredentialsDto Generate(
        string userId,
        string shopId,
        bool isSuperAdmin
    )
    {
        var endpoint = Required("PowerSync:Endpoint").TrimEnd('/');
        var keyId = Required("PowerSync:KeyId");

        var privateKeyPem = Required("PowerSync:PrivateKeyPem");
        var rsa = RSA.Create();
        rsa.ImportFromPem(privateKeyPem);
        var signingKey = new RsaSecurityKey(rsa)
        {
            KeyId = keyId
        };

        var now = DateTimeService.NowUtc;
        var configuredLifetime = _configuration.GetValue<int?>("PowerSync:TokenLifetimeMinutes") ?? 5;
        var lifetimeMinutes = Math.Clamp(configuredLifetime, 1, 60);
        var expiresAt = now.AddMinutes(lifetimeMinutes);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId),
            new Claim(nameof(ApplicationUser.ShopId), shopId),
            new Claim("IsSuperAdmin", isSuperAdmin ? "true" : "false"),
            new Claim(
                JwtRegisteredClaimNames.Iat,
                EpochTime.GetIntDate(now).ToString(),
                ClaimValueTypes.Integer64)
        };

        var token = new JwtSecurityToken(
            issuer: "SMIS",
            audience: endpoint,
            claims: claims,
            notBefore: now,
            expires: expiresAt,
            signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.RsaSha256));

        return new PowerSyncCredentialsDto(
            endpoint,
            new JwtSecurityTokenHandler().WriteToken(token),
            expiresAt);
    }

    private string Required(
        string key
    ) =>
        _configuration[key] ??
        throw new InvalidOperationException($"Required configuration '{key}' is missing.");
}