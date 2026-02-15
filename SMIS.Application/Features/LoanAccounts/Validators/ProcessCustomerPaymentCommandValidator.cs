using FluentValidation;
using SMIS.Application.Features.LoanAccounts.Commands;

namespace SMIS.Application.Features.LoanAccounts.Validators;

public class ProcessCustomerPaymentCommandValidator : AbstractValidator<ProcessCustomerPaymentCommand>
{
    public ProcessCustomerPaymentCommandValidator()
    {
        RuleFor(x => x.CustomerId)
            .NotEmpty().WithMessage("Customer ID is required");

        RuleFor(x => x.PaymentAmount)
            .GreaterThan(0).WithMessage("Payment amount must be greater than zero");

        RuleFor(x => x.PaymentDate)
            .NotEmpty().WithMessage("Payment date is required")
            .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Payment date cannot be in the future");

        RuleFor(x => x.PaymentMethod)
            .NotEmpty().WithMessage("Payment method is required");
    }
}
