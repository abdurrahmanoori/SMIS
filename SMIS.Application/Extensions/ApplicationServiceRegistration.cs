using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.Common.Behaviors;
using SMIS.Application.Features.Translations.Validators;
using System.Reflection;

namespace SMIS.Application.Extensions;

public static class ApplicationServiceRegistration
{


    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        // Register validators from the current assembly
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly(), includeInternalTypes: true);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

        return services;
    }


  
}
