using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopUpdateCommand(string Id, ShopCreateDto ShopCreateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopUpdateCommandHandler : IRequestHandler<ShopUpdateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShopUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<ShopDto>> Handle(ShopUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto.Id));
            }

            await _translationKeyRepository.AddTranslationKeysForChangedProperties(request.ShopCreateDto, entity);
            
            entity.SetName(request.ShopCreateDto.Name);
            entity.SetShopType(request.ShopCreateDto.ShopType);
            entity.SetAddress(request.ShopCreateDto.Address);
            entity.SetPhoneNumber(request.ShopCreateDto.PhoneNumber);
            entity.SetEmail(request.ShopCreateDto.Email);
            entity.SetTaxNumber(request.ShopCreateDto.TaxNumber);
            if (request.ShopCreateDto.IsActive) entity.Activate(); else entity.Deactivate();
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ShopDto>(entity);
            return Result<ShopDto>.SuccessResult(dto);
        }
    }
}
