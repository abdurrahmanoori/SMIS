using FluentValidation;
using SMIS.Application.Common.Validation;
using SMIS.Application.Features.UnitOfMeasures.Commands;

namespace SMIS.Application.Features.UnitOfMeasures.Validators;

public sealed class UnitOfMeasureSyncCreateCommandValidator : AbstractValidator<UnitOfMeasureSyncCreateCommand>
{
    public UnitOfMeasureSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
            RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Dto.Symbol).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Dto.Description).MaximumLength(500);
            RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto).Must(dto => SyncValidationRules.IsModifiedDateValid(dto.ClientCreatedDate, dto.ClientModifiedDate)).WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
            RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class UnitOfMeasureSyncUpdateCommandValidator : AbstractValidator<UnitOfMeasureSyncUpdateCommand>
{
    public UnitOfMeasureSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Dto.Symbol).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Dto.Description).MaximumLength(500);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class UnitOfMeasureSyncDeleteCommandValidator : AbstractValidator<UnitOfMeasureSyncDeleteCommand>
{
    public UnitOfMeasureSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}
