using FluentValidation;
using SMIS.Application.Features.Products.Commands;

namespace SMIS.Application.Features.Products.Validators
{
    public class ProductCreateCommandValidator : AbstractValidator<ProductCreateCommand>
    {
        public ProductCreateCommandValidator()
        {
            RuleFor(x => x.ProductCreateDto.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(x => x.ProductCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");

            RuleFor(x => x.ProductCreateDto.BaseUnitId)
                .NotEmpty().WithMessage("BaseUnitId is required");

            RuleFor(x => x.ProductCreateDto.SalePricePerBaseUnit)
                .GreaterThanOrEqualTo(0).WithMessage("SalePricePerBaseUnit must be non-negative");

            RuleFor(x => x.ProductCreateDto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.Description));

            RuleFor(x => x.ProductCreateDto.SKU)
                .NotEmpty().WithMessage("SKU is required")
                .MaximumLength(100).WithMessage("SKU must not exceed 100 characters");

            RuleFor(x => x.ProductCreateDto.Barcode)
                .MaximumLength(100).WithMessage("Barcode must not exceed 100 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.Barcode));

            RuleFor(x => x.ProductCreateDto.ImageUrl)
                .MaximumLength(500).WithMessage("ImageUrl must not exceed 500 characters")
                .Matches(@"^https?:\/\/.+\..+$").WithMessage("ImageUrl must be a valid URL")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.ImageUrl));

            RuleFor(x => x.ProductCreateDto.CategoryId)
                .MaximumLength(50).WithMessage("CategoryId must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.CategoryId));
        }
    }
}