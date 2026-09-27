using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Repositories.Customers;

namespace SMIS.Application.Features.Customers.Queries
{
    public record CustomerGetByIdQuery(string Id, bool IncludeShop = false) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerGetByIdQueryHandler : IRequestHandler<CustomerGetByIdQuery, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerGetByIdQueryHandler(
            ICustomerRepository customerRepository,
            IMapper mapper
        )
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Result<CustomerDto>> Handle(
            CustomerGetByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var dbCustomer = await _customerRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: request.IncludeShop ? "Shop" : null);

            if (dbCustomer == null)
            {
                return Result<CustomerDto>.NotFoundResult(nameof(CustomerDto));
            }

            return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(dbCustomer));
        }
    }
}