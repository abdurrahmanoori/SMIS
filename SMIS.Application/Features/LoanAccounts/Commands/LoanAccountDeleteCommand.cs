using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountDeleteCommand(string Id) : IRequest<Result>;

internal sealed class LoanAccountDeleteCommandHandler : IRequestHandler<LoanAccountDeleteCommand, Result>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly IUnitOfWork _unitOfWork;

    public LoanAccountDeleteCommandHandler(
        IUnitOfWork unitOfWork,
        ILoanAccountRepository loanAccountRepository
    )
    {
        _unitOfWork = unitOfWork;
        _loanAccountRepository = loanAccountRepository;
    }

    public async Task<Result> Handle(
        LoanAccountDeleteCommand request,
        CancellationToken cancellationToken
    )
    {
        var entity = await _loanAccountRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            return Result.NotFound(request?.Id);
        }

        await _loanAccountRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result.Success();
    }
}