using FluentValidation;
using SMIS.Application.Common.Validation;
using SMIS.Application.Features.ProductPrices.Commands;

namespace SMIS.Application.Features.ProductPrices.Validators;

public sealed class ProductPriceSyncCreateCommandValidator : AbstractValidator<ProductPriceSyncCreateCommand>
{
    public ProductPriceSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
            AddProductPriceRules(x => x.Dto);
            RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto).Must(dto => SyncValidationRules.IsModifiedDateValid(dto.ClientCreatedDate, dto.ClientModifiedDate)).WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
            RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }

    private void AddProductPriceRules(System.Linq.Expressions.Expression<Func<ProductPriceSyncCreateCommand, DTO.ProductPrices.ProductPriceSyncUpdateDto>> dto) =>
        RuleFor(dto).ChildRules(rules => AddProductPriceRules(rules));

    private static void AddProductPriceRules(InlineValidator<DTO.ProductPrices.ProductPriceSyncUpdateDto> rules)
    {
        rules.RuleFor(x => x.ProductId).NotEmpty().MaximumLength(450);
        rules.RuleFor(x => x.ProductUnitId).NotEmpty().MaximumLength(450);
        rules.RuleFor(x => x.BuyPrice).GreaterThanOrEqualTo(0);
        rules.RuleFor(x => x.SellPrice).GreaterThanOrEqualTo(0);
        rules.RuleFor(x => x.EffectiveDate).NotEmpty();
        rules.RuleFor(x => x.EndDate).GreaterThanOrEqualTo(x => x.EffectiveDate).When(x => x.EndDate.HasValue);
    }
}

public sealed class ProductPriceSyncUpdateCommandValidator : AbstractValidator<ProductPriceSyncUpdateCommand>
{
    public ProductPriceSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ProductId).NotEmpty().MaximumLength(450);
            RuleFor(x => x.Dto.ProductUnitId).NotEmpty().MaximumLength(450);
            RuleFor(x => x.Dto.BuyPrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Dto.SellPrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Dto.EffectiveDate).NotEmpty();
            RuleFor(x => x.Dto.EndDate).GreaterThanOrEqualTo(x => x.Dto.EffectiveDate).When(x => x.Dto.EndDate.HasValue);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class ProductPriceSyncDeleteCommandValidator : AbstractValidator<ProductPriceSyncDeleteCommand>
{
    public ProductPriceSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}
