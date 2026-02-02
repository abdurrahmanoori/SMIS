using FluentValidation;

namespace SMIS.Application.Features.Identity.Users.Queries
{
    public class UserGetListQueryValidator : AbstractValidator<UserGetListQuery>
    {
        public UserGetListQueryValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThan(0)
                .WithMessage("Page number must be greater than 0");

            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("Page size must be greater than 0");
        }
    }
}