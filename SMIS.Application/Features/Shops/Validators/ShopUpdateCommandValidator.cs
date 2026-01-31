using FluentValidation;
using SMIS.Application.Features.Shops.Commands;

namespace SMIS.Application.Features.Shops.Validators
{
    public class ShopUpdateCommandValidator : AbstractValidator<ShopUpdateCommand>
    {
        public ShopUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

            RuleFor(x => x.ShopCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.ShopCreateDto.Address)
                .MaximumLength(500).WithMessage("Address must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopCreateDto.Address));

            RuleFor(x => x.ShopCreateDto.PhoneNumber)
                .MinimumLength(8).WithMessage("PhoneNumber must be at least 8 characters")
                .MaximumLength(20).WithMessage("PhoneNumber must not exceed 20 characters")
                .Matches(@"^\+?[\d\s\-()]+$").WithMessage("PhoneNumber format is invalid")
                .When(x => !string.IsNullOrEmpty(x.ShopCreateDto.PhoneNumber));

            RuleFor(x => x.ShopCreateDto.Email)
                .EmailAddress().WithMessage("Email must be a valid email address")
                .MaximumLength(100).WithMessage("Email must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopCreateDto.Email));

            RuleFor(x => x.ShopCreateDto.TaxNumber)
                .MinimumLength(5).WithMessage("TaxNumber must be at least 5 characters")
                .MaximumLength(20).WithMessage("TaxNumber must not exceed 20 characters")
                .Matches(@"^[A-Z0-9\-]+$").WithMessage("TaxNumber can only contain letters, numbers, and hyphens")
                .When(x => !string.IsNullOrEmpty(x.ShopCreateDto.TaxNumber));

            RuleFor(x => x.ShopCreateDto.ShopType)
                .IsInEnum().WithMessage("ShopType must be a valid shop type");
        }
    }
}