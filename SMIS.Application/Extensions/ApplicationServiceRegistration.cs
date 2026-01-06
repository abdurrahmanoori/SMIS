using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMIS.Application.DTO.Common.Behaviors;
using SMIS.Application.Features.Patients.Commands;
using Sigtas.Application.Features.TaxRole.MaintainEnterprise.CommandValidators;
using System.Reflection;

namespace SMIS.Application.Extensions;

public static class ApplicationServiceRegistration
{


    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        services.AddValidatorsFromAssemblyContaining(typeof(CreatePatientCommandValidator),
            includeInternalTypes: true);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

        return services;
    }


  
}
