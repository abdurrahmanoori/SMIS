using FluentValidation;
using SMIS.Application.Features.ProductPrices.Commands;

namespace SMIS.Application.Features.ProductPrices.Validators;

public class ProductPriceCreateCommandValidator : AbstractValidator<ProductPriceCreateCommand>
{
    public ProductPriceCreateCommandValidator()
    {
        RuleFor(x => x.ProductPriceCreateDto.ProductId)
            .NotEmpty().WithMessage("ProductId is required");

        RuleFor(x => x.ProductPriceCreateDto.ProductUnitId)
            .NotEmpty().WithMessage("ProductUnitId is required");

        RuleFor(x => x.ProductPriceCreateDto.BuyPrice)
            .GreaterThanOrEqualTo(0).WithMessage("Buy price must be non-negative");

        RuleFor(x => x.ProductPriceCreateDto.SellPrice)
            .GreaterThanOrEqualTo(0).WithMessage("Sell price must be non-negative");

        RuleFor(x => x.ProductPriceCreateDto.EffectiveDate)
            .NotEmpty().WithMessage("EffectiveDate is required");

        RuleFor(x => x.ProductPriceCreateDto.EndDate)
            .GreaterThanOrEqualTo(x => x.ProductPriceCreateDto.EffectiveDate)
            .WithMessage("EndDate must be greater than or equal to EffectiveDate")
            .When(x => x.ProductPriceCreateDto.EndDate.HasValue);
    }
}
