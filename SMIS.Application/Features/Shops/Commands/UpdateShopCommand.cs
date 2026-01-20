using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Shops;

namespace SMIS.Application.Features.Shops.Commands
{
    public record UpdateShopCommand(string PublicId, ShopCreateDto ShopCreateDto) : IRequest<Result<ShopDto>>;

    internal sealed class UpdateShopCommandHandler : IRequestHandler<UpdateShopCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateShopCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ShopDto>> Handle(UpdateShopCommand request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.GetByIdAsync(request.PublicId);
            if (entity == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto.PublicId));
            }

            _mapper.Map(request.ShopCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ShopDto>(entity);
            return Result<ShopDto>.SuccessResult(dto);
        }
    }
}
