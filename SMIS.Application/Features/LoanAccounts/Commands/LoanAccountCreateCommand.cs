using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Application.Repositories.Sales;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountCreateCommand(LoanAccountCreateDto LoanAccountCreateDto)
    : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountCreateCommandHandler
    : IRequestHandler<LoanAccountCreateCommand, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _receivables;
    private readonly ISaleRepository _sales;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public LoanAccountCreateCommandHandler(
        ILoanAccountRepository receivables,
        ISaleRepository sales,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    )
    {
        _receivables = receivables;
        _sales = sales;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<LoanAccountDto>> Handle(
        LoanAccountCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var sale = await _sales.GetByIdWithDetailsAsync(
            request.LoanAccountCreateDto.SaleId,
            cancellationToken);

        if (sale is null)
            return Result<LoanAccountDto>.FailureResult("SaleNotFound", "The related sale does not exist.");

        if (sale.ShopId != _currentUser.GetShopId())
            return Result<LoanAccountDto>.FailureResult("Forbidden", "The sale belongs to another shop.");

        if (sale.PaymentType != SalePaymentType.Credit || string.IsNullOrWhiteSpace(sale.CustomerId))
            return Result<LoanAccountDto>.FailureResult(
                "SaleIsNotCredit",
                "Only a credit sale with a customer can create a receivable.");

        if (sale.Receivable is not null)
            return Result<LoanAccountDto>.FailureResult(
                "ReceivableAlreadyExists",
                "This sale already has a receivable.");

        var receivable = LoanAccount.Create(
            sale.Id,
            sale.CustomerId,
            sale.ShopId,
            sale.TotalAmount,
            sale.SaleDateUtc,
            request.LoanAccountCreateDto.DueDate,
            request.LoanAccountCreateDto.Notes);

        await _receivables.AddAsync(receivable);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<LoanAccountDto>.SuccessResult(_mapper.Map<LoanAccountDto>(receivable));
    }
}