using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Features.Customers;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;

namespace SMIS.Application.Features.Customers.Commands
{
    public record CustomerUpdateCommand(string Id, CustomerCreateDto CustomerCreateDto) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerUpdateCommandHandler : IRequestHandler<CustomerUpdateCommand, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            ICustomerRepository customerRepository
        )
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }

        public async Task<Result<CustomerDto>> Handle(
            CustomerUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _customerRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<CustomerDto>.NotFoundResult(nameof(CustomerDto.Id));
            }

            entity.SetFirstName(request.CustomerCreateDto.FirstName);
            entity.SetCustomerType(request.CustomerCreateDto.CustomerType);
            entity.SetLastName(request.CustomerCreateDto.LastName);
            entity.SetFatherName(request.CustomerCreateDto.FatherName);
            entity.SetEmail(request.CustomerCreateDto.Email);
            entity.SetPhoneNumber(request.CustomerCreateDto.PhoneNumber);
            entity.SetAddress(request.CustomerCreateDto.Address);
            entity.SetTaxNumber(request.CustomerCreateDto.TaxNumber);
            entity.SetProvinceId(request.CustomerCreateDto.ProvinceId);
            entity.SetDistrictId(request.CustomerCreateDto.DistrictId);
            if (request.CustomerCreateDto.IsActive) entity.Activate();
            else entity.Deactivate();
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CustomerDto>.SuccessResult(CustomerMapping.ToDto(entity));
        }
    }
}
