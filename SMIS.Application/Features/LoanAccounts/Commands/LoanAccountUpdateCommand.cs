using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountUpdateCommand(string Id, LoanAccountUpdateDto Dto)
    : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountUpdateCommandHandler
    : IRequestHandler<LoanAccountUpdateCommand, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _receivables;
    private readonly IUnitOfWork _unitOfWork;

    public LoanAccountUpdateCommandHandler(
        ILoanAccountRepository receivables,
        IUnitOfWork unitOfWork
    )
    {
        _receivables = receivables;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<LoanAccountDto>> Handle(
        LoanAccountUpdateCommand request,
        CancellationToken cancellationToken
    )
    {
        var receivable = await _receivables.GetByIdAsync(request.Id);
        if (receivable is null)
            return Result<LoanAccountDto>.NotFound(request.Id);

        // Commercial amount and sale/customer ownership are historical facts. Only
        // collection metadata may be edited after the receivable has been created.
        receivable.SetDueDate(request.Dto.DueDate);
        receivable.SetNotes(request.Dto.Notes);
        if (request.Dto.IsActive) receivable.Activate();
        else receivable.Deactivate();

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<LoanAccountDto>.Success(receivable.ToDto());
    }
}