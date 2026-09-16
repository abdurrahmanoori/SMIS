using FluentValidation;
using SMIS.Application.Features.LoanAccounts.Commands;

namespace SMIS.Application.Features.LoanAccounts.Validators;

public class LoanAccountCreateCommandValidator : AbstractValidator<LoanAccountCreateCommand>
{
    public LoanAccountCreateCommandValidator()
    {
        RuleFor(command => command.LoanAccountCreateDto.SaleId)
            .NotEmpty()
            .MaximumLength(450);

        RuleFor(command => command.LoanAccountCreateDto.DueDate)
            .GreaterThan(DateTime.UtcNow)
            .When(command => command.LoanAccountCreateDto.DueDate.HasValue)
            .WithMessage("Due date must be in the future.");

        RuleFor(command => command.LoanAccountCreateDto.Notes)
            .MaximumLength(500);
    }
}