using FluentValidation;
using SMIS.Application.Features.Products.Commands;

namespace SMIS.Application.Features.Products.Validators
{
    public class ProductUpdateCommandValidator : AbstractValidator<ProductUpdateCommand>
    {
        public ProductUpdateCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required");

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
                .MaximumLength(1000).WithMessage("Description must not exceed 1000 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.Description));

            RuleFor(x => x.ProductCreateDto.SKU)
                .NotEmpty().WithMessage("SKU is required")
                .MaximumLength(50).WithMessage("SKU must not exceed 50 characters");

            RuleFor(x => x.ProductCreateDto.Barcode)
                .MinimumLength(8).WithMessage("Barcode must be at least 8 characters")
                .MaximumLength(50).WithMessage("Barcode must not exceed 50 characters")
                .Matches(@"^[\d\-]+$").WithMessage("Barcode can only contain digits and hyphens")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.Barcode));

            RuleFor(x => x.ProductCreateDto.ImageUrl)
                .MaximumLength(500).WithMessage("ImageUrl must not exceed 500 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.ImageUrl));

            RuleFor(x => x.ProductCreateDto.CategoryId)
                .MaximumLength(50).WithMessage("CategoryId must not exceed 50 characters")
                .When(x => !string.IsNullOrEmpty(x.ProductCreateDto.CategoryId));
        }
    }
}