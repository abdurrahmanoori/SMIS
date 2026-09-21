using FluentValidation;
using SMIS.Application.Features.Sales.Commands;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Sales.Validators;

public sealed class SaleCreateCommandValidator : AbstractValidator<SaleCreateCommand>
{
    public SaleCreateCommandValidator()
    {
        RuleFor(command => command.Dto.Lines)
            .NotEmpty()
            .WithMessage("A sale must contain at least one line.");

        RuleForEach(command => command.Dto.Lines).ChildRules(line =>
        {
            line.RuleFor(item => item.ProductId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.ProductUnitId).NotEmpty().MaximumLength(450);
            line.RuleFor(item => item.QuantityEntered).GreaterThan(0);
            line.RuleFor(item => item.UnitPrice).GreaterThanOrEqualTo(0);
        });

        RuleFor(command => command.Dto.CustomerId)
            .NotEmpty()
            .When(command => command.Dto.PaymentType == SalePaymentType.Credit)
            .WithMessage("Credit sales require a customer.");

        RuleFor(command => command.Dto.DueDate)
            .GreaterThan(command => command.Dto.SaleDateUtc ?? DateTime.UtcNow)
            .When(command => command.Dto.DueDate.HasValue)
            .WithMessage("Due date must be after the sale date.");

        RuleFor(command => command.Dto.Notes)
            .MaximumLength(500);

        RuleFor(command => command.Dto.IdempotencyKey)
            .MaximumLength(200);

        RuleFor(command => command.Dto.SaleDateUtc)
            .LessThanOrEqualTo(DateTime.UtcNow.AddMinutes(5))
            .When(command => command.Dto.SaleDateUtc.HasValue)
            .WithMessage("Sale date cannot be in the future.");
    }
}