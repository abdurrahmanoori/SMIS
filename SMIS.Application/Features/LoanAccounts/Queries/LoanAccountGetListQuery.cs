using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.LoanAccounts;

namespace SMIS.Application.Features.LoanAccounts.Queries;

public record LoanAccountGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeCustomer = false, bool IncludeProduct = false) : IRequest<Result<PagedList<LoanAccountDto>>>;

internal sealed class LoanAccountGetListQueryHandler : IRequestHandler<LoanAccountGetListQuery, Result<PagedList<LoanAccountDto>>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly IMapper _mapper;

    public LoanAccountGetListQueryHandler(ILoanAccountRepository loanAccountRepository, IMapper mapper)
    {
        _loanAccountRepository = loanAccountRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<LoanAccountDto>>> Handle(LoanAccountGetListQuery request, CancellationToken cancellationToken)
    {
        var includeProperties = new List<string>();
        if (request.IncludeCustomer) includeProperties.Add("Customer");
        if (request.IncludeProduct) includeProperties.Add("Product");

        var query = _loanAccountRepository.GetAllQueryable(includeProperties: includeProperties.Any() ? string.Join(",", includeProperties) : null);
        var loanAccounts = await query.ToPagedList(request.PageNumber, request.PageSize);

        if (!loanAccounts.Items.Any())
        {
            return Result<PagedList<LoanAccountDto>>.EmptyResult(nameof(LoanAccountDto));
        }

        var loanAccountDtos = _mapper.Map<List<LoanAccountDto>>(loanAccounts.Items);

        return Result<PagedList<LoanAccountDto>>.SuccessResult(new PagedList<LoanAccountDto>
        {
            Items = loanAccountDtos,
            TotalCount = loanAccounts.TotalCount,
            PageNumber = loanAccounts.PageNumber,
            PageSize = loanAccounts.PageSize
        });
    }
}
