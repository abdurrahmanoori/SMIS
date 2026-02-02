using FluentValidation;
using SMIS.Application.Features.StockTransactions.Commands;

namespace SMIS.Application.Features.StockTransactions.Validators
{
    public class StockTransactionCreateCommandValidator : AbstractValidator<StockTransactionCreateCommand>
    {
        public StockTransactionCreateCommandValidator()
        {
            RuleFor(x => x.StockTransactionCreateDto.ShopId)
                .NotEmpty().WithMessage("ShopId is required");

            RuleFor(x => x.StockTransactionCreateDto.ProductId)
                .NotEmpty().WithMessage("ProductId is required");

            RuleFor(x => x.StockTransactionCreateDto.StockBatchId)
                .NotEmpty().WithMessage("StockBatchId is required");

            RuleFor(x => x.StockTransactionCreateDto.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than zero");

            RuleFor(x => x.StockTransactionCreateDto.UnitId)
                .NotEmpty().WithMessage("UnitId is required");

            RuleFor(x => x.StockTransactionCreateDto.Type)
                .IsInEnum().WithMessage("Type must be a valid TransactionType");

            RuleFor(x => x.StockTransactionCreateDto.TransactionDate)
                .NotEmpty().WithMessage("TransactionDate is required");

            RuleFor(x => x.StockTransactionCreateDto.Reference)
                .MaximumLength(200).WithMessage("Reference must not exceed 200 characters")
                .When(x => !string.IsNullOrEmpty(x.StockTransactionCreateDto.Reference));
        }
    }
}