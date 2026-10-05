using Microsoft.OpenApi.Models;
using SMIS.Application.Common.Models;
using System.Reflection;

namespace SMIS.Api.Extensions;

public static class SwaggerServiceCollectionExtensions
{
    public static IServiceCollection AddSwaggerWithJwt(
        this IServiceCollection services
    )
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "SMIS API",
                Version = "v1"
            });

            // OptionalValue<T> is an application-level partial-update wrapper.
            // Keep the external API contract simple so Swagger still shows the real client value, not the wrapper internals.
            options.MapType<OptionalValue<string?>>(() => new OpenApiSchema
            {
                Type = "string",
                Nullable = true
            });
            options.MapType<OptionalValue<DateTime?>>(() => new OpenApiSchema
            {
                Type = "string",
                Format = "date-time",
                Nullable = true
            });

            var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlFilePath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
            options.IncludeXmlComments(xmlFilePath, includeControllerXmlComments: true);

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Enter 'Bearer', a space, and your token."
            });

            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });

        return services;
    }
}