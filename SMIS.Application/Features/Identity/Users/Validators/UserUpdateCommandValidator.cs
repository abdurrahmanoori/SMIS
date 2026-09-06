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

            RuleFor(x => x.UserUpdateDto.UserName)
                .MaximumLength(256).WithMessage("Username must not exceed 256 characters")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.UserName));

            RuleFor(x => x.UserUpdateDto.Email)
                .EmailAddress().WithMessage("Email must be a valid email address")
                .MaximumLength(256).WithMessage("Email must not exceed 256 characters")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.Email));

            RuleFor(x => x.UserUpdateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.ShopId));

            RuleFor(x => x.UserUpdateDto.FirstName)
                .MaximumLength(100).WithMessage("First name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.FirstName));

            RuleFor(x => x.UserUpdateDto.LastName)
                .MaximumLength(100).WithMessage("Last name must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.LastName));

            RuleFor(x => x.UserUpdateDto.PhoneNumber)
                .Matches(@"^\+?[\d\s\-\(\)]+$").WithMessage("Phone number format is invalid")
                .MinimumLength(8).WithMessage("Phone number must be at least 8 characters")
                .MaximumLength(20).WithMessage("Phone number must not exceed 20 characters")
                .When(x => !string.IsNullOrEmpty(x.UserUpdateDto.PhoneNumber));

            RuleFor(x => x.UserUpdateDto.LanguageId)
                .NotEmpty().WithMessage("Language is required")
                .When(x => x.UserUpdateDto.LanguageId is not null);
        }
    }
}
