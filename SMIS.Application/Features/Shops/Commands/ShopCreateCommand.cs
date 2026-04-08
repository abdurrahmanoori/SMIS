using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Shops.Commands
{
    public record ShopCreateCommand(ShopCreateDto ShopCreateDto) : IRequest<Result<ShopDto>>;

    internal sealed class ShopCreateCommandHandler : IRequestHandler<ShopCreateCommand, Result<ShopDto>>
    {
        private readonly IShopRepository _shopRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ShopCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopRepository shopRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _shopRepository = shopRepository;
        }

        public async Task<Result<ShopDto>> Handle(ShopCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = Shop.Create(
                request.ShopCreateDto.Name,
                request.ShopCreateDto.ShopType,
                request.ShopCreateDto.Address,
                request.ShopCreateDto.PhoneNumber,
                request.ShopCreateDto.Email,
                request.ShopCreateDto.TaxNumber,
                request.ShopCreateDto.IsActive
            );

            // Use client-provided Id if available (offline sync scenario)
            if (!string.IsNullOrEmpty(request.ShopCreateDto.Id))
            {
                // Check if already exists (idempotent)
                var existing = await _shopRepository.GetByIdAsync(request.ShopCreateDto.Id);
                if (existing != null)
                    return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(existing));

                entity.Id = request.ShopCreateDto.Id;

                // Preserve original timestamps from mobile sync
                if (request.ShopCreateDto.CreatedDate.HasValue)
                    entity.CreatedDate = request.ShopCreateDto.CreatedDate.Value;
                if (!string.IsNullOrEmpty(request.ShopCreateDto.CreatedBy))
                    entity.CreatedBy = request.ShopCreateDto.CreatedBy;
                if (request.ShopCreateDto.LastModifiedUtc.HasValue)
                    entity.LastModifiedUtc = request.ShopCreateDto.LastModifiedUtc.Value;
            }

            await _shopRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ShopDto>.SuccessResult(_mapper.Map<ShopDto>(entity), "Shop Created Successfully.");
        }
    }
}
