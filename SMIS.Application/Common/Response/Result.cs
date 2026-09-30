namespace SMIS.Application.Common.Response;

public enum ErrorType
{
    Validation,
    NotFound,
    Conflict,
    Unauthorized,
    Forbidden,
    BusinessRule,
    Failure
}

public sealed record Error
{
    public string Code { get; init; } = "common.failure";
    public string? Property { get; init; }
    public string Description { get; init; } = "The operation could not be completed.";
    public ErrorType Type { get; init; } = ErrorType.BusinessRule;

    public static Error Validation(
        string code,
        string description,
        string? property = null
    ) =>
        new() { Code = code, Description = description, Property = property, Type = ErrorType.Validation };

    public static Error NotFound(
        string code,
        string description
    ) =>
        new() { Code = code, Description = description, Type = ErrorType.NotFound };

    public static Error Conflict(
        string code,
        string description,
        string? property = null
    ) =>
        new() { Code = code, Description = description, Property = property, Type = ErrorType.Conflict };

    public static Error Unauthorized(
        string code,
        string description
    ) =>
        new() { Code = code, Description = description, Type = ErrorType.Unauthorized };

    public static Error Forbidden(
        string code,
        string description
    ) =>
        new() { Code = code, Description = description, Type = ErrorType.Forbidden };

    public static Error BusinessRule(
        string code,
        string description,
        string? property = null
    ) =>
        new() { Code = code, Description = description, Property = property, Type = ErrorType.BusinessRule };

    public static Error Failure(
        string code,
        string description
    ) =>
        new() { Code = code, Description = description, Type = ErrorType.Failure };

    public override string ToString() =>
        $"Code: {Code}, Property: {Property}, Description: {Description}, Type: {Type}";
}

public interface IResult
{
    bool IsSuccess { get; }
    IReadOnlyList<Error> Errors { get; }
}

public interface IResult<TSelf> : IResult where TSelf : IResult<TSelf>
{
    static abstract TSelf Failure(
        IReadOnlyCollection<Error> errors
    );
}

public sealed class Result : IResult<Result>
{
    public bool IsSuccess { get; init; }
    public IReadOnlyList<Error> Errors { get; init; } = Array.Empty<Error>();

    public static Result Success() =>
        new() { IsSuccess = true };

    public static Result NotFound(
        string? id = null
    ) =>
        Failure(Error.NotFound(
            "common.not_found",
            id is null ? "The requested resource was not found." : $"Entity with id '{id}' was not found."));

    public static Result NotFound(
        string code,
        string description
    ) =>
        Failure(Error.NotFound(code, description));

    public static Result BusinessRule(
        string code,
        string description
    ) =>
        Failure(Error.BusinessRule(code, description));

    public static Result BusinessRule(
        string description
    ) =>
        Failure(Error.BusinessRule("common.business_rule", description));

    public static Result Conflict(
        string code,
        string description,
        string? property = null
    ) =>
        Failure(Error.Conflict(code, description, property));

    public static Result Unauthorized(
        string code,
        string description
    ) =>
        Failure(Error.Unauthorized(code, description));

    public static Result Forbidden(
        string code,
        string description
    ) =>
        Failure(Error.Forbidden(code, description));

    public static Result Validation(
        string code,
        string description,
        string? property = null
    ) =>
        Failure(Error.Validation(code, description, property));

    public static Result Failure(
        IReadOnlyCollection<Error> errors
    ) =>
        new() { IsSuccess = false, Errors = errors.ToArray() };

    public static Result Failure(
        Error error
    ) => Failure(new[] { error });
}

public sealed class Result<T> : IResult<Result<T>>
{
    public T? Value { get; init; }
    public bool IsSuccess { get; init; }
    public IReadOnlyList<Error> Errors { get; init; } = Array.Empty<Error>();

    public static Result<T> Success(
        T? result
    ) =>
        new()
        {
            IsSuccess = true,
            Value = result
        };

    public static Result<T> NotFound(
        string? id = null
    ) =>
        Failure(Error.NotFound(
            "common.not_found",
            id is null ? "The requested resource was not found." : $"Entity with id '{id}' was not found."));

    public static Result<T> NotFound(
        string code,
        string description
    ) =>
        Failure(Error.NotFound(code, description));

    // Expected application/business-rule failures belong in Result rather than exceptions.
    public static Result<T> BusinessRule(
        string code,
        string description
    ) =>
        Failure(Error.BusinessRule(code, description));

    public static Result<T> BusinessRule(
        string description
    ) =>
        Failure(Error.BusinessRule("common.business_rule", description));

    public static Result<T> Conflict(
        string code,
        string description,
        string? property = null
    ) =>
        Failure(Error.Conflict(code, description, property));

    public static Result<T> Unauthorized(
        string code,
        string description
    ) =>
        Failure(Error.Unauthorized(code, description));

    public static Result<T> Forbidden(
        string code,
        string description
    ) =>
        Failure(Error.Forbidden(code, description));

    public static Result<T> Validation(
        string code,
        string description,
        string? property = null
    ) =>
        Failure(Error.Validation(code, description, property));

    public static Result<T> Failure(
        IReadOnlyCollection<Error> errors
    ) =>
        new()
        {
            IsSuccess = false,
            Errors = errors.ToArray()
        };

    public static Result<T> Failure(
        Error error
    ) => Failure(new[] { error });
}