using FluentValidation;
using SMIS.Application.Features.Categories.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Categories.Validators;

// ------------------------------------------------------------
// Create Validator
// ------------------------------------------------------------

public sealed class CategorySyncCreateCommandValidator
    : AbstractValidator<CategorySyncCreateCommand>
{
    public CategorySyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto)
            .NotNull()
            .DependentRules(() =>
            {
                RuleFor(x => x.Dto.Id)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty()
                    .Must(BeValidGuid)
                    .WithMessage(
                        "Category sync ID must be a valid GUID.");

                RuleFor(x => x.Dto.Name)
                    .NotEmpty()
                    .MaximumLength(200);

                RuleFor(x => x.Dto.Code)
                    .MaximumLength(50);

                RuleFor(x => x.Dto.Description)
                    .MaximumLength(500);

                RuleFor(x => x.Dto.ClientModifiedDate)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty()
                    .Must(BeReasonableUtcTimestamp)
                    .WithMessage(
                        "ClientModifiedDate must contain a valid UTC timestamp.");
            });
    }

    private static bool BeValidGuid(
        string value
    ) =>
        Guid.TryParse(value, out _);

    private static bool BeReasonableUtcTimestamp(
        DateTime value
    )
    {
        if (value == default)
            return false;

        return DateTimeService.NormalizeUtc(value)
               <= DateTimeService.NowUtc.AddMinutes(5);
    }

}

// ------------------------------------------------------------
// Update Validator
// ------------------------------------------------------------

public sealed class CategorySyncUpdateCommandValidator
    : AbstractValidator<CategorySyncUpdateCommand>
{
    public CategorySyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Must(BeValidGuid)
            .WithMessage(
                "Category sync ID must be a valid GUID.");

        RuleFor(x => x.Dto)
            .NotNull()
            .DependentRules(() =>
            {
                RuleFor(x => x.Dto.Name)
                    .NotEmpty()
                    .MaximumLength(200);

                RuleFor(x => x.Dto.Code)
                    .MaximumLength(50);

                RuleFor(x => x.Dto.Description)
                    .MaximumLength(500);

                RuleFor(x => x.Dto.ClientModifiedDate)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty()
                    .Must(BeReasonableUtcTimestamp)
                    .WithMessage(
                        "ClientModifiedDate must contain a valid UTC timestamp.");

            });
    }

    private static bool BeValidGuid(
        string value
    ) =>
        Guid.TryParse(value, out _);

    private static bool BeReasonableUtcTimestamp(
        DateTime value
    )
    {
        if (value == default)
            return false;

        return DateTimeService.NormalizeUtc(value)
               <= DateTimeService.NowUtc.AddMinutes(5);
    }
}

// ------------------------------------------------------------
// Delete Validator
// ------------------------------------------------------------

public sealed class CategorySyncDeleteCommandValidator
    : AbstractValidator<CategorySyncDeleteCommand>
{
    public CategorySyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Must(BeValidGuid)
            .WithMessage(
                "Category sync ID must be a valid GUID.");

        RuleFor(x => x.Dto)
            .NotNull()
            .DependentRules(() =>
            {
                RuleFor(x => x.Dto.ClientModifiedDate)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty()
                    .Must(BeReasonableUtcTimestamp)
                    .WithMessage(
                        "ClientModifiedDate must contain a valid UTC timestamp.");

            });
    }

    private static bool BeValidGuid(
        string value
    ) =>
        Guid.TryParse(value, out _);

    private static bool BeReasonableUtcTimestamp(
        DateTime value
    )
    {
        if (value == default)
            return false;

        return DateTimeService.NormalizeUtc(value)
               <= DateTimeService.NowUtc.AddMinutes(5);
    }
}