using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ShopOwners;
using SMIS.Application.Repositories.Shops;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ShopOwners.Commands;

public record ShopOwnerCreateCommand(ShopOwnerCreateDto ShopOwnerCreateDto) : IRequest<Result<ShopOwnerDto>>;

internal sealed class ShopOwnerCreateCommandHandler : IRequestHandler<ShopOwnerCreateCommand, Result<ShopOwnerDto>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ShopOwnerCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IShopOwnerRepository shopOwnerRepository, IShopRepository shopRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _shopOwnerRepository = shopOwnerRepository;
        _shopRepository = shopRepository;
    }

    public async Task<Result<ShopOwnerDto>> Handle(ShopOwnerCreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ShopOwner>(request.ShopOwnerCreateDto);
        
        // Populate name fields
        var shop = await _shopRepository.GetByIdAsync(request.ShopOwnerCreateDto.ShopId);
        entity.ShopName = shop?.Name ?? string.Empty;
        
        await _shopOwnerRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ShopOwnerDto>.SuccessResult(_mapper.Map<ShopOwnerDto>(entity));
    }
}