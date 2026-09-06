using FluentValidation;
using SMIS.Application.Common.Validation;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Features.Customers.Commands;

namespace SMIS.Application.Features.Customers.Validators;

public sealed class CustomerSyncCreateCommandValidator : AbstractValidator<CustomerSyncCreateCommand>
{
    public CustomerSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
            AddCustomerRules(x => x.Dto);
            RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto).Must(dto => SyncValidationRules.IsModifiedDateValid(dto.ClientCreatedDate, dto.ClientModifiedDate)).WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
            RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }

    private void AddCustomerRules(System.Linq.Expressions.Expression<Func<CustomerSyncCreateCommand, CustomerCreateDto>> dto) =>
        RuleFor(dto).ChildRules(rules => AddCustomerRules(rules));

    private static void AddCustomerRules(InlineValidator<CustomerCreateDto> rules)
    {
        rules.RuleFor(x => x.FirstName).NotEmpty().MaximumLength(100);
        rules.RuleFor(x => x.CustomerType).IsInEnum();
        rules.RuleFor(x => x.LastName).MaximumLength(100);
        rules.RuleFor(x => x.FatherName).MaximumLength(100);
        rules.RuleFor(x => x.Email).EmailAddress().MaximumLength(100).When(x => !string.IsNullOrWhiteSpace(x.Email));
        rules.RuleFor(x => x.PhoneNumber).MaximumLength(20);
        rules.RuleFor(x => x.Address).MaximumLength(500);
        rules.RuleFor(x => x.TaxNumber).MaximumLength(20);
    }
}

public sealed class CustomerSyncUpdateCommandValidator : AbstractValidator<CustomerSyncUpdateCommand>
{
    public CustomerSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.FirstName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Dto.CustomerType).IsInEnum();
            RuleFor(x => x.Dto.LastName).MaximumLength(100);
            RuleFor(x => x.Dto.FatherName).MaximumLength(100);
            RuleFor(x => x.Dto.Email).EmailAddress().MaximumLength(100).When(x => !string.IsNullOrWhiteSpace(x.Dto.Email));
            RuleFor(x => x.Dto.PhoneNumber).MaximumLength(20);
            RuleFor(x => x.Dto.Address).MaximumLength(500);
            RuleFor(x => x.Dto.TaxNumber).MaximumLength(20);
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}

public sealed class CustomerSyncDeleteCommandValidator : AbstractValidator<CustomerSyncDeleteCommand>
{
    public CustomerSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(SyncValidationRules.BeValidGuid);
        RuleFor(x => x.Dto).NotNull().DependentRules(() =>
        {
            RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(SyncValidationRules.BeReasonableUtcTimestamp);
            RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
        });
    }
}
