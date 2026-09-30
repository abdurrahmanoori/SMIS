using FluentValidation;

namespace SMIS.Application.Features.Identity.Users.Queries;

public sealed class UserQueryValidator : AbstractValidator<UserQuery>
{
    public UserQueryValidator()
    {
        RuleFor(query => query.Query.PageNumber)
            .GreaterThan(0)
            .When(query => query.Query.PageNumber.HasValue)
            .WithMessage("Page number must be greater than 0");

        RuleFor(query => query.Query.PageSize)
            .GreaterThan(0)
            .When(query => query.Query.PageSize.HasValue)
            .WithMessage("Page size must be greater than 0");

        RuleFor(query => query.Query.PageSize)
            .LessThanOrEqualTo(100)
            .When(query => query.Query.PageSize.HasValue)
            .WithMessage("Page size must not exceed 100");
    }
}