using FluentValidation;
using Microsoft.AspNetCore.Identity;
using SMIS.Application.Features.Identity.Users.Commands;
using SMIS.Domain.Entities.Identity.Entity;

namespace SMIS.Application.Features.Identity.Users.Validators
{
    public class UserCreateCommandValidator : AbstractValidator<UserCreateCommand>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserCreateCommandValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            RuleFor(x => x.UserCreateDto.UserName)
                .NotEmpty().WithMessage("Username is required")
                .MaximumLength(256).WithMessage("Username must not exceed 256 characters");

            RuleFor(x => x.UserCreateDto.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email must be a valid email address")
                .MaximumLength(256).WithMessage("Email must not exceed 256 characters")
                .MustAsync(async (email, cancellation) => await BeUniqueEmail(email))
                .WithMessage("Email already exists");

            RuleFor(x => x.UserCreateDto.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters");

            RuleFor(x => x.UserCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");

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

        private async Task<bool> BeUniqueEmail(string email)
        {
            var existingUser = await _userManager.FindByEmailAsync(email);
            return existingUser == null;
        }
    }
}