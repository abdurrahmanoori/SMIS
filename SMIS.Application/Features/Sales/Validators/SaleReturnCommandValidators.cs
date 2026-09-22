using FluentValidation;
using SMIS.Application.Features.Sales.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Sales.Validators;

public sealed class SaleReturnCommandValidator : AbstractValidator<SaleReturnCommand>
{
    public SaleReturnCommandValidator()
    {
        RuleFor(command => command.SaleId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.Lines).NotEmpty();
        RuleForEach(command => command.Dto.Lines).ChildRules(line =>
        {
            line.RuleFor(item => item.SaleLineId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.QuantityEntered).GreaterThan(0);
        });
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OccurredAtUtc)
            .LessThanOrEqualTo(DateTimeService.NowUtc.AddMinutes(5))
            .When(command => command.Dto.OccurredAtUtc.HasValue);
    }
}

public sealed class SaleVoidCommandValidator : AbstractValidator<SaleVoidCommand>
{
    public SaleVoidCommandValidator()
    {
        RuleFor(command => command.SaleId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OccurredAtUtc)
            .LessThanOrEqualTo(DateTimeService.NowUtc.AddMinutes(5))
            .When(command => command.Dto.OccurredAtUtc.HasValue);
    }
}