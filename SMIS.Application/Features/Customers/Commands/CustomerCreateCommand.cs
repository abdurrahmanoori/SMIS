using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Application.Identity.IServices;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Customers.Commands
{
    public record CustomerCreateCommand(CustomerCreateDto CustomerCreateDto) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommand, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;

        public CustomerCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ICustomerRepository customerRepository,
            ICurrentUser currentUser
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customerRepository = customerRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<CustomerDto>> Handle(
            CustomerCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var shopId = _currentUser.GetShopId();
            if (string.IsNullOrWhiteSpace(shopId))
                return Result<CustomerDto>.FailureResult("ShopContextRequired", "An active shop is required.");

            var dto = request.CustomerCreateDto;
            var entity = Customer.Create(
                dto.FirstName,
                shopId,
                dto.CustomerType,
                dto.LastName,
                dto.FatherName,
                dto.Email,
                dto.PhoneNumber,
                dto.Address,
                dto.TaxNumber,
                dto.ProvinceId,
                dto.DistrictId,
                dto.IsActive);

            await _customerRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(entity));
        }
    }
}