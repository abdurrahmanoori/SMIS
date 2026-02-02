using FluentValidation;
using SMIS.Application.Features.Identity.Users.Commands;

namespace SMIS.Application.Features.Identity.Users.Validators
{
    public class UserUpdateCommandValidator : AbstractValidator<UserUpdateCommand>
    {
        public UserUpdateCommandValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("UserId is required");

            RuleFor(x => x.UserCreateDto.Email)
                .EmailAddress().WithMessage("Email must be a valid email address")
                .MaximumLength(256).WithMessage("Email must not exceed 256 characters")
                .When(x => !string.IsNullOrEmpty(x.UserCreateDto.Email));

            RuleFor(x => x.UserCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required")
                .When(x => !string.IsNullOrEmpty(x.UserCreateDto.ShopId));

            RuleFor(x => x.UserCreateDto.FirstName)
                .MaximumLength(100).WithMessage("First name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.UserCreateDto.FirstName));

            RuleFor(x => x.UserCreateDto.LastName)
                .MaximumLength(100).WithMessage("Last name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.UserCreateDto.LastName));

            RuleFor(x => x.UserCreateDto.PhoneNumber)
                .Matches(@"^\+?[\d\s\-\(\)]+$").WithMessage("Phone number format is invalid")
                .MinimumLength(8).WithMessage("Phone number must be at least 8 characters")
                .MaximumLength(20).WithMessage("Phone number must not exceed 20 characters")
                .When(x => !string.IsNullOrEmpty(x.UserCreateDto.PhoneNumber));
        }
    }
}