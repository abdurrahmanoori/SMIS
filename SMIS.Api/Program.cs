using FluentValidation.AspNetCore;
using SMIS.Api.Extensions;
using SMIS.Infrastructure.Extensions;
using SMIS.Application.Extensions;
using SMIS.Infrastructure.Context;
using SMIS.Identity.Extensions;
using SMIS.Api.Converters;
using SMIS.Domain.Enums;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddSerilogService();

// Add services to the container.
builder.Services.AddControllers()
    .AddControllersAsServices()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new StringEnumConverter<ShopType>());
    });

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7216");
});

builder.Services.AddReactAppCors();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

// Configure services
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureIdentityServices<AppDbContext>(builder.Configuration);
var enf = builder.Environment.EnvironmentName;
// Add database logging
builder.Services.AddDatabaseLogging();

// MiniProfiler registration
builder.Services.AddMiniProfilerServices();

var app = builder.Build();

// Configure middleware pipeline
app.UseExceptionLogging();

app.UseSwaggerWithUI(app.Environment);
app.UseMiniProfiler();
app.UseCors("AllowReactApp");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

public partial class Program { }
