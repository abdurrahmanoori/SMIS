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

        public ShopUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ShopDto>> Handle(ShopUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _shopRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ShopDto>.NotFoundResult(nameof(ShopDto.Id));
            }

            // Update using domain methods
            entity.SetName(request.ShopUpdateDto.Name);
            entity.SetShopType(request.ShopUpdateDto.ShopType);
            entity.SetAddress(request.ShopUpdateDto.Address);
            entity.SetPhoneNumber(request.ShopUpdateDto.PhoneNumber);
            entity.SetEmail(request.ShopUpdateDto.Email);
            entity.SetTaxNumber(request.ShopUpdateDto.TaxNumber);
            if (request.ShopUpdateDto.IsActive) entity.Activate(); else entity.Deactivate();

            // Preserve timestamps from mobile sync if provided
            if (request.ShopUpdateDto.UpdatedDate.HasValue)
                entity.UpdatedDate = request.ShopUpdateDto.UpdatedDate.Value;
            if (!string.IsNullOrEmpty(request.ShopUpdateDto.UpdatedBy))
                entity.UpdatedBy = request.ShopUpdateDto.UpdatedBy;
            if (request.ShopUpdateDto.LastModifiedUtc.HasValue)
                entity.LastModifiedUtc = request.ShopUpdateDto.LastModifiedUtc.Value;

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ShopDto>(entity);
            return Result<ShopDto>.SuccessResult(dto);
        }
    }
}
