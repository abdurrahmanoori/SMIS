using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Customers.Commands
{
    public record CustomerCreateCommand(CustomerCreateDto CustomerCreateDto) : IRequest<Result<CustomerDto>>;

    internal sealed class CustomerCreateCommandHandler : IRequestHandler<CustomerCreateCommand, Result<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ICustomerRepository customerRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _customerRepository = customerRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<CustomerDto>> Handle(CustomerCreateCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.CustomerCreateDto, _unitOfWork);

            var entity = _mapper.Map<Customer>(request.CustomerCreateDto);
            
            await _customerRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(entity));
        }
    }
}