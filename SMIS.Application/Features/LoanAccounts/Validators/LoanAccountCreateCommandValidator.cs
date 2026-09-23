using FluentValidation;
using SMIS.Application.Features.LoanAccounts.Commands;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.LoanAccounts.Validators;

public class LoanAccountCreateCommandValidator : AbstractValidator<LoanAccountCreateCommand>
{
    public LoanAccountCreateCommandValidator()
    {
        RuleFor(command => command.LoanAccountCreateDto.SaleId)
            .NotEmpty()
            .MaximumLength(450);

        RuleFor(command => command.LoanAccountCreateDto.DueDate)
            .GreaterThan(DateTimeService.NowUtc)
            .When(command => command.LoanAccountCreateDto.DueDate.HasValue)
            .WithMessage("Due date must be in the future.");

        RuleFor(command => command.LoanAccountCreateDto.Notes)
            .MaximumLength(500);
    }
}