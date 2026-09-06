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
using SMIS.Infrastructure.Server.Services.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.shared.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

DateTimeService.UseUtc = builder.Configuration.GetValue<bool>("UseUtcTime");

builder.AddSerilogService();

builder.Services.AddControllers()
    .AddControllersAsServices()
    .AddJsonOptions(options =>
    {
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

builder.Services.ConfigurePersistenceServices(builder.Configuration, builder.Environment);
builder.Services.ConfigureApplicationServices();
builder.Services.AddIdentityServices<AppDbContext>();
builder.Services.AddJwtAuthentication(builder.Configuration);

builder.Services.AddScoped<ICurrentUser, CurrentUser>();

builder.Services.AddMiniProfilerServices();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseSwaggerWithUI();
app.UseMiniProfiler();

app.UseStaticFiles();
app.UseCors("AllowReactApp");
app.UseHttpsRedirection();
app.UseRouting();

app.UseMiddleware<LogEnrichmentMiddleware>();
app.UseMiddleware<RequestResponseLoggingMiddleware>();

app.UseMiddleware<DevelopmentJwtMiddleware>();

app.UseAuthentication();
app.UseMiddleware<UnauthorizedMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
