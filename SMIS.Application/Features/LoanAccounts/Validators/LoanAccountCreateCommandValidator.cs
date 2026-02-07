using FluentValidation;
using SMIS.Application.Features.LoanAccounts.Commands;

namespace SMIS.Application.Features.LoanAccounts.Validators;

public class LoanAccountCreateCommandValidator : AbstractValidator<LoanAccountCreateCommand>
{
    public LoanAccountCreateCommandValidator()
    {
        RuleFor(x => x.LoanAccountCreateDto.CustomerId)
            .NotEmpty().WithMessage("CustomerId is required");

        RuleFor(x => x.LoanAccountCreateDto.ShopId)
            .NotEmpty().WithMessage("ShopId is required");

        RuleFor(x => x.LoanAccountCreateDto.ProductId)
            .NotEmpty().WithMessage("ProductId is required");

        RuleFor(x => x.LoanAccountCreateDto.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero");

        RuleFor(x => x.LoanAccountCreateDto.UnitId)
            .NotEmpty().WithMessage("UnitId is required");

        RuleFor(x => x.LoanAccountCreateDto.TotalAmount)
            .GreaterThan(0).WithMessage("Total amount must be greater than zero");

        RuleFor(x => x.LoanAccountCreateDto.DueDate)
            .GreaterThan(DateTime.UtcNow).WithMessage("Due date must be in the future")
            .When(x => x.LoanAccountCreateDto.DueDate.HasValue);

        RuleFor(x => x.LoanAccountCreateDto.Notes)
            .MaximumLength(500).WithMessage("Notes must not exceed 500 characters")
            .When(x => !string.IsNullOrEmpty(x.LoanAccountCreateDto.Notes));
    }
}
