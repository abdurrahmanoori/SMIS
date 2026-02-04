using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Extensions;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Customers;

namespace SMIS.Application.Features.Customers.Queries
{
    public record CustomerGetByIdQuery(string Id, bool IncludeShop = false) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerGetByIdQueryHandler : IRequestHandler<CustomerGetByIdQuery, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;

        public CustomerGetByIdQueryHandler(ICustomerRepository customerRepository, ITranslationKeyRepository translationKeyRepository, ICurrentUser currentUser, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _translationKeyRepository = translationKeyRepository;
            _currentUser = currentUser;
            _mapper = mapper;
        }

        public async Task<Result<CustomerDto>> Handle(CustomerGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbCustomer = await _customerRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: request.IncludeShop ? "Shop" : null);

            if (dbCustomer == null)
            {
                return Result<CustomerDto>.NotFoundResult(nameof(CustomerDto));
            }

            var customer = _mapper.Map<CustomerDto>(dbCustomer);
            customer.TranslateEntityByAttributes(_translationKeyRepository.GetAllQueryable(), _currentUser.GetLangId());

            return Result<CustomerDto>.SuccessResult(customer);
        }
    }
}