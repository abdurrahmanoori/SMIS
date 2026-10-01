using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Features.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;

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

        receivable.SetDueDate(request.Dto.DueDate);
        receivable.SetNotes(request.Dto.Notes);
        if (request.Dto.IsActive) receivable.Activate();
        else receivable.Deactivate();

        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<LoanAccountDto>.Success(LoanAccountMapping.ToDto(receivable));
    }
}
