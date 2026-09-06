using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Customers;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Customers.Queries;

public record CustomerPullQuery(DateTime ChangedSince) : IRequest<Result<List<CustomerDto>>>;
internal sealed class CustomerPullQueryHandler : IRequestHandler<CustomerPullQuery, Result<List<CustomerDto>>>
{
    private readonly ICustomerRepository _repository; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public CustomerPullQueryHandler(ICustomerRepository repository, ICurrentUser currentUser, IMapper mapper) => (_repository, _currentUser, _mapper) = (repository, currentUser, mapper);
    public async Task<Result<List<CustomerDto>>> Handle(CustomerPullQuery request, CancellationToken cancellationToken)
    {
        var shopId = _currentUser.GetShopId(); var isSuperAdmin = _currentUser.IsSuperAdmin(); var since = DateTimeService.NormalizeUtc(request.ChangedSince);
        var customers = await _repository.GetAllAsync(c => c.LastModifiedUtc > since && (isSuperAdmin || c.ShopId == shopId), ignoreQueryFilters: true);
        return Result<List<CustomerDto>>.SuccessResult(_mapper.Map<List<CustomerDto>>(customers));
    }
}
