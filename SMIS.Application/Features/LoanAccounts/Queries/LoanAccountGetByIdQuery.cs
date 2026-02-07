using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.LoanAccounts;

namespace SMIS.Application.Features.LoanAccounts.Queries;

public record LoanAccountGetByIdQuery(string Id, bool IncludeCustomer = false, bool IncludeProduct = false) : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountGetByIdQueryHandler : IRequestHandler<LoanAccountGetByIdQuery, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly IMapper _mapper;

    public LoanAccountGetByIdQueryHandler(ILoanAccountRepository loanAccountRepository, IMapper mapper)
    {
        _loanAccountRepository = loanAccountRepository;
        _mapper = mapper;
    }

    public async Task<Result<LoanAccountDto>> Handle(LoanAccountGetByIdQuery request, CancellationToken cancellationToken)
    {
        var includeProperties = new List<string>();
        if (request.IncludeCustomer) includeProperties.Add("Customer");
        if (request.IncludeProduct) includeProperties.Add("Product");

        var dbLoanAccount = await _loanAccountRepository.GetFirstOrDefaultAsync(
            x => x.Id == request.Id,
            includeProperties: includeProperties.Any() ? string.Join(",", includeProperties) : null);

        if (dbLoanAccount == null)
        {
            return Result<LoanAccountDto>.NotFoundResult(nameof(LoanAccountDto));
        }

        var loanAccount = _mapper.Map<LoanAccountDto>(dbLoanAccount);

        return Result<LoanAccountDto>.SuccessResult(loanAccount);
    }
}
