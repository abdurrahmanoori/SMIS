using FluentValidation;
using SMIS.Application.Features.Purchasing.Commands;

namespace SMIS.Application.Features.Purchasing.Validators;

public sealed class SupplierCreateCommandValidator : AbstractValidator<SupplierCreateCommand>
{
    public SupplierCreateCommandValidator()
    {
        RuleFor(command => command.Dto.ShopId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.Name).NotEmpty().MaximumLength(200);
        RuleFor(command => command.Dto.PhoneNumber).MaximumLength(50);
        RuleFor(command => command.Dto.Notes).MaximumLength(500);
    }
}

public sealed class PurchaseOrderCreateCommandValidator : AbstractValidator<PurchaseOrderCreateCommand>
{
    public PurchaseOrderCreateCommandValidator()
    {
        RuleFor(command => command.Dto.ShopId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.SupplierId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.ReferenceNumber).MaximumLength(100);
        RuleFor(command => command.Dto.Notes).MaximumLength(500);
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OrderedAtUtc)
            .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
            .When(command => command.Dto.OrderedAtUtc.HasValue);
        RuleFor(command => command.Dto.Lines).NotEmpty();
        RuleForEach(command => command.Dto.Lines).ChildRules(line =>
        {
            line.RuleFor(item => item.ProductId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.ProductUnitId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.QuantityEntered).GreaterThan(0);
            line.RuleFor(item => item.UnitCostBase).GreaterThanOrEqualTo(0);
        });
    }
}

public sealed class PurchaseOrderReceiveCommandValidator : AbstractValidator<PurchaseOrderReceiveCommand>
{
    public PurchaseOrderReceiveCommandValidator()
    {
        RuleFor(command => command.Id).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OccurredAtUtc)
            .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
            .When(command => command.Dto.OccurredAtUtc.HasValue);
        RuleFor(command => command.Dto.Lines).NotEmpty();
        RuleForEach(command => command.Dto.Lines).ChildRules(line =>
        {
            line.RuleFor(item => item.PurchaseOrderLineId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.QuantityEntered).GreaterThan(0);
            line.RuleFor(item => item.BatchNumber).MaximumLength(50);
        });
    }
}

public sealed class PurchaseOrderSupplierReturnCommandValidator : AbstractValidator<PurchaseOrderSupplierReturnCommand>
{
    public PurchaseOrderSupplierReturnCommandValidator()
    {
        RuleFor(command => command.Id).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.PurchaseOrderLineId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.StockBatchId).NotEmpty().MaximumLength(450);
        RuleFor(command => command.Dto.QuantityEntered).GreaterThan(0);
        RuleFor(command => command.Dto.IdempotencyKey).MaximumLength(200);
        RuleFor(command => command.Dto.OccurredAtUtc)
            .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
            .When(command => command.Dto.OccurredAtUtc.HasValue);
    }
}

public sealed class PurchaseOrderCancelCommandValidator : AbstractValidator<PurchaseOrderCancelCommand>
{
    public PurchaseOrderCancelCommandValidator() =>
        RuleFor(command => command.Id).NotEmpty().MaximumLength(450);
}
