using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Repositories.Customers;

namespace SMIS.Application.Features.Customers.Queries
{
    public record CustomerGetListQuery(int PageNumber = 1, int PageSize = 25, bool IncludeShop = false)
        : IRequest<Result<PagedList<CustomerDto>>>;

    internal sealed class
        CustomerGetListQueryHandler : IRequestHandler<CustomerGetListQuery, Result<PagedList<CustomerDto>>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerGetListQueryHandler(
            ICustomerRepository customerRepository,
            IMapper mapper
        )
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<CustomerDto>>> Handle(
            CustomerGetListQuery request,
            CancellationToken cancellationToken
        )
        {
            var query = _customerRepository.GetAllQueryable(includeProperties: request.IncludeShop ? "Shop" : null);
            var customers = await query.ToPagedList(request.PageNumber, request.PageSize);

            if (!customers.Items.Any())
            {
                return Result<PagedList<CustomerDto>>.EmptyResult(nameof(CustomerDto));
            }

            var customerDtos = _mapper.Map<List<CustomerDto>>(customers.Items);
            return Result<PagedList<CustomerDto>>.SuccessResult(new PagedList<CustomerDto>
            {
                Items = customerDtos,
                TotalCount = customers.TotalCount,
                PageNumber = customers.PageNumber,
                PageSize = customers.PageSize
            });
        }
    }
}