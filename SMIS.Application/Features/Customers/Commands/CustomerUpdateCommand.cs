using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Customers.Commands
{
    public record CustomerUpdateCommand(string Id, CustomerCreateDto CustomerCreateDto) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerUpdateCommandHandler : IRequestHandler<CustomerUpdateCommand, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICustomerRepository customerRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customerRepository = customerRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<CustomerDto>> Handle(CustomerUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _customerRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<CustomerDto>.NotFoundResult(nameof(CustomerDto.Id));
            }

            await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.CustomerCreateDto, entity);
            
            // Update using domain methods
            entity.SetFirstName(request.CustomerCreateDto.FirstName);
            entity.SetShopId(request.CustomerCreateDto.ShopId);
            entity.SetCustomerType(request.CustomerCreateDto.CustomerType);
            entity.SetLastName(request.CustomerCreateDto.LastName);
            entity.SetFatherName(request.CustomerCreateDto.FatherName);
            entity.SetEmail(request.CustomerCreateDto.Email);
            entity.SetPhoneNumber(request.CustomerCreateDto.PhoneNumber);
            entity.SetAddress(request.CustomerCreateDto.Address);
            entity.SetTaxNumber(request.CustomerCreateDto.TaxNumber);
            entity.SetProvinceId(request.CustomerCreateDto.ProvinceId);
            entity.SetDistrictId(request.CustomerCreateDto.DistrictId);
            if (request.CustomerCreateDto.IsActive) entity.Activate(); else entity.Deactivate();
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<CustomerDto>(entity);
            return Result<CustomerDto>.SuccessResult(dto);
        }
    }
}