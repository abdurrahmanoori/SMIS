using FluentValidation;
using SMIS.Application.Common.Validation;
using SMIS.Application.Features.ProductUnits.Commands;

namespace SMIS.Application.Features.ProductUnits.Validators;

public sealed class ProductUnitSyncCreateCommandValidator : AbstractValidator<ProductUnitSyncCreateCommand>
{
    public ProductUnitSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
            AddProductUnitRules(x => x.Dto);
            RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto).Must(dto => SyncValidationRules.IsModifiedDateValid(dto.ClientCreatedDate, dto.ClientModifiedDate)).WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
            RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }

    private void AddProductUnitRules(System.Linq.Expressions.Expression<Func<ProductUnitSyncCreateCommand, DTO.ProductUnits.ProductUnitSyncUpdateDto>> dto) =>
        RuleFor(dto).ChildRules(rules => AddProductUnitRules(rules));

    private static void AddProductUnitRules(InlineValidator<DTO.ProductUnits.ProductUnitSyncUpdateDto> rules)
    {
        rules.RuleFor(x => x.ProductId).NotEmpty().MaximumLength(450);
        rules.RuleFor(x => x.UnitOfMeasureId).NotEmpty().MaximumLength(450);
        rules.RuleFor(x => x.ConversionFactor).GreaterThan(0).PrecisionScale(18, 2, false);
    }
}

public sealed class ProductUnitSyncUpdateCommandValidator : AbstractValidator<ProductUnitSyncUpdateCommand>
{
    public ProductUnitSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ProductId).NotEmpty().MaximumLength(450);
            RuleFor(x => x.Dto.UnitOfMeasureId).NotEmpty().MaximumLength(450);
            RuleFor(x => x.Dto.ConversionFactor).GreaterThan(0).PrecisionScale(18, 2, false);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class ProductUnitSyncDeleteCommandValidator : AbstractValidator<ProductUnitSyncDeleteCommand>
{
    public ProductUnitSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}
