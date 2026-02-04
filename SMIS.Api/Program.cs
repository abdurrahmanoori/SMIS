using FluentValidation.AspNetCore;
using SMIS.Api.Converters;
using SMIS.Application.Extensions;
using SMIS.Domain.Enums;
using SMIS.Infrastructure.Extensions;
using SMIS.Infrastructure.Context;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using SMIS.Domain.Entities.Identity.Entity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Api.Middleware;
using SMIS.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddSerilogService();

// Add services to the container.
builder.Services.AddControllers()
    .AddControllersAsServices()
    .AddJsonOptions(options =>
    {
        //options.JsonSerializerOptions.Converters.Add(new StringEnumConverter<ShopType>());
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

    });

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7216");
});

builder.Services.AddReactAppCors();
builder.Services.AddSwaggerWithJwt();
builder.Services.AddHttpContextAccessor();

// Configure services
builder.Services.ConfigurePersistenceServices(builder.Configuration,builder.Environment);
builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureIdentityServices<AppDbContext>(builder.Configuration);

builder.Services.AddScoped<ICurrentUser, CurrentUser>();

var enf = builder.Environment.EnvironmentName;
// Add database logging
builder.Services.AddDatabaseLogging();

// MiniProfiler registration
builder.Services.AddMiniProfilerServices();

var app = builder.Build();

// Configure middleware pipeline
// Exception handling should be first
app.UseMiddleware<ExceptionMiddleware>();

// Development tools
app.UseSwaggerWithUI(app.Environment);
app.UseMiniProfiler();

// Serve static files for theme assets
app.UseStaticFiles();

// CORS before authentication
app.UseCors("AllowReactApp");

// HTTPS redirection
app.UseHttpsRedirection();

// Routing
app.UseRouting();

// Logging middleware after routing but before authentication
app.UseMiddleware<LogEnrichmentMiddleware>();
app.UseMiddleware<RequestResponseLoggingMiddleware>();

// Authentication and authorization
app.UseAuthentication();
app.UseMiddleware<UnauthorizedMiddleware>();
app.UseAuthorization();

// Controllers mapping
app.MapControllers();

app.Run();

public partial class Program { }
