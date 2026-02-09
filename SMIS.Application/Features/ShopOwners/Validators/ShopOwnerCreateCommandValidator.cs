using FluentValidation;
using SMIS.Application.Features.ShopOwners.Commands;
using SMIS.Application.Validators;

namespace SMIS.Application.Features.ShopOwners.Validators
{
    public class ShopOwnerCreateCommandValidator : AbstractValidator<ShopOwnerCreateCommand>
    {
        public ShopOwnerCreateCommandValidator()
        {
            RuleFor(x => x.ShopOwnerCreateDto.ApplicationUserId)
                .NotEmpty().WithMessage("ApplicationUserId is required");

            RuleFor(x => x.ShopOwnerCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");

            RuleFor(x => x.ShopOwnerCreateDto.FirstName)
                .MaximumLength(100).WithMessage("FirstName must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.FirstName));

            RuleFor(x => x.ShopOwnerCreateDto.LastName)
                .MaximumLength(100).WithMessage("LastName must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.LastName));

            RuleFor(x => x.ShopOwnerCreateDto.NationalIdCardNumber)
                .MaximumLength(50).WithMessage("NationalIdCardNumber must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.NationalIdCardNumber));

            RuleFor(x => x.ShopOwnerCreateDto.PhoneNumber)
                .AfghanistanPhoneNumber()
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.PhoneNumber));

            RuleFor(x => x.ShopOwnerCreateDto.Email)
                .EmailAddress().WithMessage("Email must be a valid email address")
                .MaximumLength(256).WithMessage("Email must not exceed 256 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.Email));

            RuleFor(x => x.ShopOwnerCreateDto.Address)
                .MaximumLength(500).WithMessage("Address must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.Address));

            RuleFor(x => x.ShopOwnerCreateDto.OwnershipPercentage)
                .InclusiveBetween(0, 100).WithMessage("OwnershipPercentage must be between 0 and 100");

            RuleFor(x => x.ShopOwnerCreateDto.ProvinceId)
                .MaximumLength(50).WithMessage("ProvinceId must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.ProvinceId));

            RuleFor(x => x.ShopOwnerCreateDto.DistrictId)
                .MaximumLength(50).WithMessage("DistrictId must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.ShopOwnerCreateDto.DistrictId));
        }
    }
}