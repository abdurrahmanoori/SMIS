using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Infrastructure.Server.Services.Identity;
using System.Text;

namespace SMIS.Infrastructure.Server.Extensions;

public static class IdentityServicesRegistration
{
    /// <summary>
    /// Registers ASP.NET Identity (UserManager, SignInManager, RoleManager).
    /// Called by all hosts — API, Blazor Server, etc.
    /// </summary>
    public static IServiceCollection AddIdentityServices<TContext>(
        this IServiceCollection services
    )
        where TContext : DbContext
    {
        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<TContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<ApplicationUserClaimsPrincipalFactory>();

        return services;
    }

    /// <summary>
    /// Registers JWT bearer authentication.
    /// Called only by hosts that authenticate via JWT — SMIS.Api.
    /// </summary>
    public static IServiceCollection AddJwtAuthentication(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var jwtSection = configuration.GetSection(JwtSettings.SectionName);
        var jwtSettings = new JwtSettings
        {
            Key = jwtSection[nameof(JwtSettings.Key)] ?? string.Empty,
            Issuer = jwtSection[nameof(JwtSettings.Issuer)] ?? string.Empty,
            Audience = jwtSection[nameof(JwtSettings.Audience)] ?? string.Empty,
            AccessTokenLifetimeMinutes = jwtSection.GetValue<int>(nameof(JwtSettings.AccessTokenLifetimeMinutes)),
            RefreshTokenLifetimeDays = jwtSection.GetValue<int>(nameof(JwtSettings.RefreshTokenLifetimeDays)),
            RefreshTokenSizeBytes = jwtSection.GetValue<int>(nameof(JwtSettings.RefreshTokenSizeBytes)),
            ClockSkewSeconds = jwtSection.GetValue<int>(nameof(JwtSettings.ClockSkewSeconds))
        };

        if (string.IsNullOrWhiteSpace(jwtSettings.Key) ||
            string.IsNullOrWhiteSpace(jwtSettings.Issuer) ||
            string.IsNullOrWhiteSpace(jwtSettings.Audience) ||
            jwtSettings.AccessTokenLifetimeMinutes <= 0 ||
            jwtSettings.RefreshTokenLifetimeDays <= 0 ||
            jwtSettings.RefreshTokenSizeBytes < 32 ||
            jwtSettings.ClockSkewSeconds < 0)
        {
            throw new InvalidOperationException("JwtSettings contains missing or invalid authentication values.");
        }

        services.Configure<JwtSettings>(jwtSection);

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromSeconds(jwtSettings.ClockSkewSeconds),
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key))
                };

                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var tokenVersion = context.Principal?
                            .FindFirst(JwtClaimNames.AccessTokenVersion)?
                            .Value;

                        if (!string.Equals(
                                tokenVersion,
                                JwtClaimNames.CurrentAccessTokenVersion,
                                StringComparison.Ordinal))
                        {
                            context.Fail("The access token is from an unsupported session version. Sign in again.");
                        }

                        return Task.CompletedTask;
                    }
                };
            });

        return services;
    }
}