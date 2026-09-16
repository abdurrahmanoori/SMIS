using FluentValidation;
using SMIS.Application.Features.StockMovements.Commands;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.StockMovements.Validators;

public sealed class StockMovementFifoIssueCommandValidator : AbstractValidator<StockMovementFifoIssueCommand>
{
    public StockMovementFifoIssueCommandValidator()
    {
        RuleFor(x => x.Dto.ProductId).NotEmpty().MaximumLength(450);
        RuleFor(x => x.Dto.ProductUnitId).NotEmpty().MaximumLength(450);
        RuleFor(x => x.Dto.QuantityEntered).GreaterThan(0);
        RuleFor(x => x.Dto.Reason)
            .Must(reason =>
                reason is not StockMovementReason.PurchaseReceipt and not StockMovementReason.CustomerReturn)
            .WithMessage("FIFO issues must use an OUT-compatible movement reason.");
        RuleFor(x => x.Dto.ReferenceType).MaximumLength(100);
        RuleFor(x => x.Dto.ReferenceId).MaximumLength(450);
        RuleFor(x => x.Dto)
            .Must(dto => string.IsNullOrWhiteSpace(dto.ReferenceType) == string.IsNullOrWhiteSpace(dto.ReferenceId))
            .WithMessage("ReferenceType and ReferenceId must either both be supplied or both be empty.");
    }
}