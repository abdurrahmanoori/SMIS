using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Common.Behaviors;
using SMIS.Application.Services;
using SMIS.Domain.Services;
using System.Reflection;

namespace SMIS.Application.Extensions;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection ConfigureApplicationServices(
        this IServiceCollection services
    )
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DomainExceptionPipelineBehavior<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

        // Register validators from the current assembly
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly(), includeInternalTypes: true);

        // NOTE: ICurrentUser is NOT registered here - each infrastructure layer provides its own implementation
        // - Web API: Uses CurrentUser with IHttpContextAccessor (registered in SMIS.Api)
        // - Mobile: Uses MobileCurrentUser with Preferences (registered in SMIS.Infrastructure.Mobile)

        // Register domain services
        services.AddScoped<PaymentAllocationService>();

        // All physical stock changes are orchestrated here. Feature handlers must not
        // update StockBatch balances or create StockMovement rows independently.
        services.AddScoped<IInventoryService, InventoryService>();
        services.AddScoped<IIdempotencyService, IdempotencyService>();

        return services;
    }
}