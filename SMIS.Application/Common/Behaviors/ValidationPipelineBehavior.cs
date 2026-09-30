using FluentValidation;
using MediatR;
using SMIS.Application.Common.Response;

namespace SMIS.Application.Common.Behaviors;

public sealed class ValidationPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IResult<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationPipelineBehavior(
        IEnumerable<IValidator<TRequest>> validators
    )
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken
    )
    {
        if (!_validators.Any())
            return await next();

        var context = new ValidationContext<TRequest>(request);
        var validationResults = await Task.WhenAll(
            _validators.Select(validator => validator.ValidateAsync(context, cancellationToken)));

        var errors = validationResults
            .SelectMany(result => result.Errors)
            .Where(error => error is not null)
            .Select(error => Error.Validation(
                string.IsNullOrWhiteSpace(error.ErrorCode) ? "validation.failed" : error.ErrorCode,
                error.ErrorMessage,
                NormalizeProperty(error.PropertyName)))
            .Distinct()
            .ToArray();

        return errors.Length == 0
            ? await next()
            : TResponse.Failure(errors);
    }

    private static string? NormalizeProperty(
        string? propertyName
    )
    {
        if (string.IsNullOrWhiteSpace(propertyName))
            return null;

        var separatorIndex = propertyName.LastIndexOf('.');
        var normalized = separatorIndex >= 0
            ? propertyName[(separatorIndex + 1)..]
            : propertyName;

        return normalized.ToLowerInvariant();
    }
}