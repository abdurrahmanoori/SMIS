using FluentValidation;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Validators;

public class CategorySyncCreateCommandValidator : AbstractValidator<CategorySyncCreateCommand>
{
    public CategorySyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto.Id)
            .NotEmpty()
            .Must(id => Guid.TryParse(id, out _))
            .WithMessage("Category sync ID must be a valid GUID.");
        RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Dto.Code).MaximumLength(50);
        RuleFor(x => x.Dto.Description).MaximumLength(500);
        RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(BeReasonableUtcTimestamp);
        RuleFor(x => x.Dto.ClientModifiedDate)
            .NotEmpty()
            .Must(BeReasonableUtcTimestamp)
            .GreaterThanOrEqualTo(x => x.Dto.ClientCreatedDate)
            .WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
        RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }

    private static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default && DateTimeService.NormalizeUtc(value) <= DateTime.UtcNow.AddMinutes(5);
}

public class CategorySyncUpdateCommandValidator : AbstractValidator<CategorySyncUpdateCommand>
{
    public CategorySyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .Must(id => Guid.TryParse(id, out _))
            .WithMessage("Category sync ID must be a valid GUID.");
        RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Dto.Code).MaximumLength(50);
        RuleFor(x => x.Dto.Description).MaximumLength(500);
        RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(BeReasonableUtcTimestamp);
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }

    private static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default && DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);
}

public class CategorySyncDeleteCommandValidator : AbstractValidator<CategorySyncDeleteCommand>
{
    public CategorySyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .Must(id => Guid.TryParse(id, out _))
            .WithMessage("Category sync ID must be a valid GUID.");
        RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(BeReasonableUtcTimestamp);
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }

    private static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default && DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);
}
