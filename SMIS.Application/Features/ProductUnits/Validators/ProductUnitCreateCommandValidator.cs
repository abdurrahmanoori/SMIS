using FluentValidation;
using SMIS.Application.Features.ProductUnits.Commands;

namespace SMIS.Application.Features.ProductUnits.Validators
{
    public class ProductUnitCreateCommandValidator : AbstractValidator<ProductUnitCreateCommand>
    {
        public ProductUnitCreateCommandValidator()
        {
            RuleFor(x => x.ProductUnitCreateDto.ProductId)
                .NotEmpty().WithMessage("ProductId is required");

            RuleFor(x => x.ProductUnitCreateDto.UnitOfMeasureId)
                .NotEmpty().WithMessage("UnitOfMeasureId is required");

            RuleFor(x => x.ProductUnitCreateDto.BaseUnitQuantity)
                .GreaterThan(0).WithMessage("Base unit quantity must be greater than 0")
                .PrecisionScale(18, 2, false).WithMessage("Base unit quantity cannot have more than 18 digits in total with 2 decimal places");
        }
    }
}
