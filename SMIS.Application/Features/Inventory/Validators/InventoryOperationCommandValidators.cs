using FluentValidation;
using SMIS.Application.Features.Inventory.Commands;

namespace SMIS.Application.Features.Inventory.Validators;

public sealed class InventoryBatchOperationCommandValidator
    : AbstractValidator<InventoryBatchOperationCommand>
{
    public InventoryBatchOperationCommandValidator()
    {
        RuleFor(x => x.Dto.StockBatchId)
            .NotEmpty();

        RuleFor(x => x.Dto.ProductUnitId)
            .NotEmpty();

        RuleFor(x => x.Dto.QuantityEntered)
            .GreaterThan(0);

        RuleFor(x => x.Direction)
            .IsInEnum();

        RuleFor(x => x.Reason)
            .IsInEnum();

        RuleFor(x => x.Dto)
            .Must(dto => string.IsNullOrWhiteSpace(dto.ReferenceType) == string.IsNullOrWhiteSpace(dto.ReferenceId))
            .WithMessage("ReferenceType and ReferenceId must either both be supplied or both be empty.");

        RuleFor(x => x.Dto.IdempotencyKey)
            .MaximumLength(200);
    }
}

public sealed class InventoryTransferCommandValidator
    : AbstractValidator<InventoryTransferCommand>
{
    public InventoryTransferCommandValidator()
    {
        RuleFor(x => x.Dto.SourceStockBatchId)
            .NotEmpty();

        RuleFor(x => x.Dto.DestinationStockBatchId)
            .NotEmpty()
            .NotEqual(x => x.Dto.SourceStockBatchId);

        RuleFor(x => x.Dto.ProductUnitId)
            .NotEmpty();

        RuleFor(x => x.Dto.QuantityEntered)
            .GreaterThan(0);

        RuleFor(x => x.Dto)
            .Must(dto => string.IsNullOrWhiteSpace(dto.ReferenceType) == string.IsNullOrWhiteSpace(dto.ReferenceId))
            .WithMessage("ReferenceType and ReferenceId must either both be supplied or both be empty.");

        RuleFor(x => x.Dto.IdempotencyKey)
            .MaximumLength(200);
    }
}