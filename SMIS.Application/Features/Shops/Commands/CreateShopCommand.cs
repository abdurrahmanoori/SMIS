using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Shops.Commands
{
    public record CreateShopCommand(ShopCreateDto ShopCreateDto) : IRequest<Result<ShopCreateDto>>;

    internal sealed class CreateShopCommandHandler : IRequestHandler<CreateShopCommand, Result<ShopCreateDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateShopCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopRepository shopRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<ShopCreateDto>> Handle(CreateShopCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.ShopCreateDto, _unitOfWork);
            
            var entity = _mapper.Map<Shop>(request.ShopCreateDto);
            await _shopRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ShopCreateDto>.SuccessResult(request.ShopCreateDto);
        }
    }
}
