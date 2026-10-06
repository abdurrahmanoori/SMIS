using FluentValidation;
using SMIS.Application.Features.Purchasing.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Purchasing.Validators;

public sealed class SupplierSyncCreateCommandValidator
    : AbstractValidator<SupplierSyncCreateCommand>
{
    public SupplierSyncCreateCommandValidator()
    {
        RuleFor(command => command.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(command => command.Dto.Id)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(BeValidGuid)
                .WithMessage("Supplier sync ID must be a valid GUID.");
            RuleFor(command => command.Dto.Name).NotEmpty().MaximumLength(200);
            RuleFor(command => command.Dto.PhoneNumber).MaximumLength(50);
            RuleFor(command => command.Dto.Notes).MaximumLength(500);
            RuleFor(command => command.Dto.ClientModifiedDate)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(BeReasonableUtcTimestamp)
                .WithMessage("ClientModifiedDate must contain a valid UTC timestamp.");
        });
    }

    private static bool BeValidGuid(string value) => Guid.TryParse(value, out _);

    private static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default &&
        DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);
}

public sealed class SupplierSyncUpdateCommandValidator
    : AbstractValidator<SupplierSyncUpdateCommand>
{
    public SupplierSyncUpdateCommandValidator()
    {
        RuleFor(command => command.Id)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Must(BeValidGuid)
            .WithMessage("Supplier sync ID must be a valid GUID.");
        RuleFor(command => command.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(command => command.Dto.Name).NotEmpty().MaximumLength(200);
            RuleFor(command => command.Dto.PhoneNumber).MaximumLength(50);
            RuleFor(command => command.Dto.Notes).MaximumLength(500);
            RuleFor(command => command.Dto.ClientModifiedDate)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(BeReasonableUtcTimestamp)
                .WithMessage("ClientModifiedDate must contain a valid UTC timestamp.");
        });
    }

    private static bool BeValidGuid(string value) => Guid.TryParse(value, out _);

    private static bool BeReasonableUtcTimestamp(DateTime value) =>
        value != default &&
        DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);
}
