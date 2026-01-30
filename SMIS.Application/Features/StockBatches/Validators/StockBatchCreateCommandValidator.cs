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

            RuleFor(x => x.StockBatchCreateDto.UnitId)
                .NotEmpty().WithMessage("Unit ID is required")
                .MaximumLength(50).WithMessage("Unit ID cannot exceed 50 characters");

            RuleFor(x => x.StockBatchCreateDto.Quantity)
                .GreaterThanOrEqualTo(0).WithMessage("Quantity cannot be negative");

            RuleFor(x => x.StockBatchCreateDto.PurchasePrice)
                .GreaterThanOrEqualTo(0).WithMessage("Purchase price cannot be negative");

            RuleFor(x => x.StockBatchCreateDto.ReceivedDate)
                .LessThanOrEqualTo(DateTime.UtcNow.AddDays(1))
                .WithMessage("Received date cannot be in the future")
                .When(x => x.StockBatchCreateDto.ReceivedDate.HasValue);

            RuleFor(x => x.StockBatchCreateDto.BatchNumber)
                .MaximumLength(50).WithMessage("Batch number cannot exceed 50 characters")
                .When(x => !string.IsNullOrWhiteSpace(x.StockBatchCreateDto.BatchNumber));

            RuleFor(x => x.StockBatchCreateDto.ExpirationDate)
                .GreaterThan(x => x.StockBatchCreateDto.ReceivedDate ?? DateTime.UtcNow)
                .WithMessage("Expiration date must be after received date")
                .When(x => x.StockBatchCreateDto.ExpirationDate.HasValue);
        }
    }
}