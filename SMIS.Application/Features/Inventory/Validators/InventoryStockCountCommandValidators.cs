using FluentValidation;
using SMIS.Application.Features.Inventory.Commands;

namespace SMIS.Application.Features.Inventory.Validators;

public sealed class StockCountStartCommandValidator : AbstractValidator<StockCountStartCommand>
{
    public StockCountStartCommandValidator()
    {
        RuleFor(command => command.Dto.ShopId).MaximumLength(450);
        RuleFor(command => command.Dto.Notes).MaximumLength(500);
        RuleForEach(command => command.Dto.StockBatchIds)
            .NotEmpty()
            .MaximumLength(450);
    }
}

public sealed class StockCountCompleteCommandValidator : AbstractValidator<StockCountCompleteCommand>
{
    public StockCountCompleteCommandValidator()
    {
        RuleFor(command => command.Id).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.Counts).NotEmpty();
        RuleForEach(command => command.Dto.Counts).ChildRules(count =>
        {
            count.RuleFor(item => item.StockBatchId).NotEmpty().MaximumLength(450);
            count.RuleFor(item => item.CountedQuantityBase).GreaterThanOrEqualTo(0);
        });
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OccurredAtUtc)
            .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
            .When(command => command.Dto.OccurredAtUtc.HasValue);
    }
}

public sealed class StockCountCancelCommandValidator : AbstractValidator<StockCountCancelCommand>
{
    public StockCountCancelCommandValidator() =>
        RuleFor(command => command.Id).NotEmpty().MaximumLength(450);
}
