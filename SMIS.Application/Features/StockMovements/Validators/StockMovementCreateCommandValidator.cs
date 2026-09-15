using FluentValidation;
using SMIS.Application.Features.StockMovements.Commands;

namespace SMIS.Application.Features.StockMovements.Validators;

public sealed class StockMovementCreateCommandValidator : AbstractValidator<StockMovementCreateCommand>
{
    public StockMovementCreateCommandValidator()
    {
        RuleFor(x => x.Dto.StockBatchId).NotEmpty().MaximumLength(450);
        RuleFor(x => x.Dto.ProductUnitId).NotEmpty().MaximumLength(450);
        RuleFor(x => x.Dto.QuantityEntered).GreaterThan(0);
        RuleFor(x => x.Dto.ReferenceType).MaximumLength(100);
        RuleFor(x => x.Dto.ReferenceId).MaximumLength(450);
    }
}
