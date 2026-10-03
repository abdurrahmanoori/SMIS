using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SMIS.Domain.Entities.Identity.Entity;
using SMIS.Infrastructure.Server.Services.Identity;
using System.Security.Claims;
using System.Globalization;
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
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!))
                };

                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = async context =>
                    {
                        var userId = context.Principal?
                            .FindFirst(ClaimTypes.NameIdentifier)?
                            .Value;
                        if (string.IsNullOrWhiteSpace(userId))
                        {
                            context.Fail("The authenticated user could not be resolved.");
                            return;
                        }

                        var userManager = context.HttpContext.RequestServices
                            .GetRequiredService<UserManager<ApplicationUser>>();
                        var user = await userManager.FindByIdAsync(userId);
                        if (user is null)
                        {
                            context.Fail("The authenticated user no longer exists.");
                            return;
                        }

                        if (!user.IsActive)
                        {
                            context.Fail("The user account is inactive.");
                            return;
                        }

                        if (user.LockoutEnabled &&
                            user.LockoutEnd.HasValue &&
                            user.LockoutEnd.Value > DateTimeOffset.UtcNow)
                        {
                            context.Fail("The user account is locked.");
                            return;
                        }

                        var securityVersionValue = context.Principal?
                            .FindFirst(JwtClaimNames.SecurityVersion)?
                            .Value;
                        if (string.IsNullOrWhiteSpace(securityVersionValue) ||
                            !int.TryParse(
                                securityVersionValue,
                                NumberStyles.None,
                                CultureInfo.InvariantCulture,
                                out var tokenSecurityVersion))
                        {
                            context.Fail("The authentication session is no longer valid.");
                            return;
                        }

                        if (tokenSecurityVersion != user.SecurityVersion)
                        {
                            context.Fail("The authentication session has been invalidated.");
                        }
                    }
                };
            });

        return services;
    }
}