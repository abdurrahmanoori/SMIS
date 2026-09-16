using FluentValidation;
using SMIS.Application.Features.StockBatches.Commands;

namespace SMIS.Application.Features.StockBatches.Validators
{
    public class StockBatchCreateCommandValidator : AbstractValidator<StockBatchCreateCommand>
    {
        public StockBatchCreateCommandValidator()
        {
            RuleFor(x => x.StockBatchCreateDto.ProductId)
                .NotEmpty().WithMessage("Product ID is required")
                .MaximumLength(50).WithMessage("Product ID cannot exceed 50 characters");

            RuleFor(x => x.StockBatchCreateDto.ReceivedProductUnitId)
                .NotEmpty().WithMessage("Received product unit ID is required")
                .MaximumLength(450).WithMessage("Received product unit ID cannot exceed 450 characters");

            RuleFor(x => x.StockBatchCreateDto.ReceivedQuantity)
                .GreaterThan(0).WithMessage("Received quantity must be greater than zero");

            RuleFor(x => x.StockBatchCreateDto.UnitCostBase)
                .GreaterThanOrEqualTo(0).WithMessage("Base-unit cost cannot be negative");

            RuleFor(x => x.StockBatchCreateDto.ReceivedAtUtc)
                .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
                .WithMessage("Received time cannot be in the future")
                .When(x => x.StockBatchCreateDto.ReceivedAtUtc.HasValue);

            RuleFor(x => x.StockBatchCreateDto.BatchNumber)
                .MaximumLength(50).WithMessage("Batch number cannot exceed 50 characters")
                .When(x => !string.IsNullOrWhiteSpace(x.StockBatchCreateDto.BatchNumber));

            RuleFor(x => x.StockBatchCreateDto.ExpirationDate)
                .GreaterThan(x => x.StockBatchCreateDto.ReceivedAtUtc ?? DateTime.UtcNow)
                .WithMessage("Expiration date must be after received date")
                .When(x => x.StockBatchCreateDto.ExpirationDate.HasValue);

            RuleFor(x => x.StockBatchCreateDto.ReferenceType)
                .MaximumLength(100);

            RuleFor(x => x.StockBatchCreateDto.ReferenceId)
                .MaximumLength(450);

            RuleFor(x => x.StockBatchCreateDto)
                .Must(dto => string.IsNullOrWhiteSpace(dto.ReferenceType) == string.IsNullOrWhiteSpace(dto.ReferenceId))
                .WithMessage("ReferenceType and ReferenceId must either both be supplied or both be empty.");
        }
    }
}