using FluentValidation;
using SMIS.Application.Common.Validation;
using SMIS.Application.Features.Products.Commands;

namespace SMIS.Application.Features.Products.Validators;

public sealed class ProductSyncCreateCommandValidator : AbstractValidator<ProductSyncCreateCommand>
{
    public ProductSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
            AddProductRules(x => x.Dto);
            RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto).Must(dto => SyncValidationRules.IsModifiedDateValid(dto.ClientCreatedDate, dto.ClientModifiedDate)).WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
            RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }

    private void AddProductRules(System.Linq.Expressions.Expression<Func<ProductSyncCreateCommand, DTO.Products.ProductSyncUpdateDto>> dto) =>
        RuleFor(dto).ChildRules(rules => AddProductRules(rules));

    private static void AddProductRules(InlineValidator<DTO.Products.ProductSyncUpdateDto> rules)
    {
        rules.RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        rules.RuleFor(x => x.BaseUnitId).NotEmpty().MaximumLength(450);
        rules.RuleFor(x => x.Description).MaximumLength(500);
        rules.RuleFor(x => x.SKU).MaximumLength(100);
        rules.RuleFor(x => x.Barcode).MaximumLength(100);
        rules.RuleFor(x => x.ImageUrl).MaximumLength(500);
        rules.RuleFor(x => x.CategoryId).MaximumLength(450);
    }
}

public sealed class ProductSyncUpdateCommandValidator : AbstractValidator<ProductSyncUpdateCommand>
{
    public ProductSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Dto.BaseUnitId).NotEmpty().MaximumLength(450);
            RuleFor(x => x.Dto.Description).MaximumLength(500);
            RuleFor(x => x.Dto.SKU).MaximumLength(100);
            RuleFor(x => x.Dto.Barcode).MaximumLength(100);
            RuleFor(x => x.Dto.ImageUrl).MaximumLength(500);
            RuleFor(x => x.Dto.CategoryId).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class ProductSyncDeleteCommandValidator : AbstractValidator<ProductSyncDeleteCommand>
{
    public ProductSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}
