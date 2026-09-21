using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopUpdateCommand(string Id, ShopUpdateDto ShopUpdateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopUpdateCommandHandler : IRequestHandler<ShopUpdateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShopUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IShopRepository shopRepository
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ShopDto>> Handle(
            ShopUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto.Id));
            }

            ShopCommandRules.Apply(entity, request.ShopUpdateDto);

            entity.ClearClientModificationMetadata();

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ShopDto>(entity);
            return Result<ShopDto>.SuccessResult(dto);
        }
    }
}