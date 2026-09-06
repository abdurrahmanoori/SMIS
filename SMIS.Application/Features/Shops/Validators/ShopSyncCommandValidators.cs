using FluentValidation;
using SMIS.Application.Features.Shops.Commands;
using SMIS.Domain.Enums;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Shops.Validators;

public sealed class ShopSyncCreateCommandValidator : AbstractValidator<ShopSyncCreateCommand>
{
    public ShopSyncCreateCommandValidator()
    {
        RuleFor(x => x.Dto.Id).NotEmpty().Must(BeValidGuid);
        AddShopRules(x => x.Dto);
        RuleFor(x => x.Dto.ClientCreatedDate).NotEmpty().Must(BeReasonableUtcTimestamp);
        RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(BeReasonableUtcTimestamp);
        RuleFor(x => x.Dto).Must(dto => DateTimeService.NormalizeUtc(dto.ClientModifiedDate) >= DateTimeService.NormalizeUtc(dto.ClientCreatedDate))
            .WithMessage("ClientModifiedDate cannot be earlier than ClientCreatedDate.");
        RuleFor(x => x.Dto.ClientCreatedBy).MaximumLength(450);
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }

    private void AddShopRules(System.Linq.Expressions.Expression<Func<ShopSyncCreateCommand, SMIS.Application.DTO.Shops.ShopSyncCreateDto>> dto)
    {
        RuleFor(dto).ChildRules(rules =>
        {
            rules.RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
            rules.RuleFor(x => x.Address).MaximumLength(500).When(x => !string.IsNullOrEmpty(x.Address));
            rules.RuleFor(x => x.PhoneNumber).MinimumLength(8).MaximumLength(20).Matches(@"^\+?[\d\s\-()]+$").When(x => !string.IsNullOrEmpty(x.PhoneNumber));
            rules.RuleFor(x => x.Email).EmailAddress().MaximumLength(100).When(x => !string.IsNullOrEmpty(x.Email));
            rules.RuleFor(x => x.TaxNumber).MinimumLength(5).MaximumLength(20).Matches(@"^[A-Z0-9\-]+$").When(x => !string.IsNullOrEmpty(x.TaxNumber));
            rules.RuleFor(x => x.ShopType).IsInEnum();
        });
    }

    private static bool BeValidGuid(string? value) => Guid.TryParse(value, out _);
    private static bool BeReasonableUtcTimestamp(DateTime value) => value != default && DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5);
}

public sealed class ShopSyncUpdateCommandValidator : AbstractValidator<ShopSyncUpdateCommand>
{
    public ShopSyncUpdateCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(value => Guid.TryParse(value, out _));
        RuleFor(x => x.Dto.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Dto.Address).MaximumLength(500).When(x => !string.IsNullOrEmpty(x.Dto.Address));
        RuleFor(x => x.Dto.PhoneNumber).MinimumLength(8).MaximumLength(20).Matches(@"^\+?[\d\s\-()]+$").When(x => !string.IsNullOrEmpty(x.Dto.PhoneNumber));
        RuleFor(x => x.Dto.Email).EmailAddress().MaximumLength(100).When(x => !string.IsNullOrEmpty(x.Dto.Email));
        RuleFor(x => x.Dto.TaxNumber).MinimumLength(5).MaximumLength(20).Matches(@"^[A-Z0-9\-]+$").When(x => !string.IsNullOrEmpty(x.Dto.TaxNumber));
        RuleFor(x => x.Dto.ShopType).IsInEnum();
        RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(value => value != default && DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5));
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }
}

public sealed class ShopSyncDeleteCommandValidator : AbstractValidator<ShopSyncDeleteCommand>
{
    public ShopSyncDeleteCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().Must(value => Guid.TryParse(value, out _));
        RuleFor(x => x.Dto.ClientModifiedDate).NotEmpty().Must(value => value != default && DateTimeService.NormalizeUtc(value) <= DateTimeService.NowUtc.AddMinutes(5));
        RuleFor(x => x.Dto.ClientModifiedBy).MaximumLength(450);
    }
}
