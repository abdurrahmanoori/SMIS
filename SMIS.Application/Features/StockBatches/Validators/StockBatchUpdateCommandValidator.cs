using FluentValidation;
using SMIS.Application.Features.StockBatches.Commands;

namespace SMIS.Application.Features.StockBatches.Validators;

public sealed class StockBatchUpdateCommandValidator : AbstractValidator<StockBatchUpdateCommand>
{
    public StockBatchUpdateCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("ID is required");

        RuleFor(x => x.StockBatchUpdateDto.BatchNumber)
            .MaximumLength(50).WithMessage("Batch number cannot exceed 50 characters")
            .When(x => !string.IsNullOrWhiteSpace(x.StockBatchUpdateDto.BatchNumber));

        RuleFor(x => x.StockBatchUpdateDto.Status)
            .IsInEnum()
            .When(x => x.StockBatchUpdateDto.Status.HasValue);
    }
}