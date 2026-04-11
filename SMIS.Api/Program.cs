using FluentValidation.AspNetCore;
using SMIS.Api.Extensions;
using SMIS.Api.Middleware;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Services;
using SMIS.Infrastructure.Server.Context;
using SMIS.Infrastructure.Server.Extensions;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Load shared configuration first, then project-specific appsettings override it
// SetBasePath ensures files are resolved from the output directory where MSBuild copies linked files
builder.Configuration
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.shared.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

DateTimeService.UseUtc = builder.Configuration.GetValue<bool>("UseUtcTime");

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
builder.Services.ConfigurePersistenceServices(builder.Configuration, builder.Environment);
builder.Services.ConfigureApplicationServices();
builder.Services.AddIdentityServices<AppDbContext>();
builder.Services.AddJwtAuthentication(builder.Configuration);

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

// Auto-inject JWT token in development
app.UseMiddleware<DevelopmentJwtMiddleware>();

// Authentication and authorization
app.UseAuthentication();
app.UseMiddleware<UnauthorizedMiddleware>();
app.UseAuthorization();

// Controllers mapping
app.MapControllers();

app.Run();

public partial class Program { }
