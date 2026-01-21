using FluentValidation;
using SMIS.Application.Features.Products.Commands;

namespace SMIS.Application.Features.Products.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
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
        }
    }
}