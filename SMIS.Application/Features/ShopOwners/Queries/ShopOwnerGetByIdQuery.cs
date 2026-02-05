using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ShopOwners;
using SMIS.Application.Repositories.ShopOwners;

namespace SMIS.Application.Features.ShopOwners.Queries;

public record ShopOwnerGetByIdQuery(string Id) : IRequest<Result<ShopOwnerDto>>;

internal sealed class ShopOwnerGetByIdQueryHandler : IRequestHandler<ShopOwnerGetByIdQuery, Result<ShopOwnerDto>>
{
    private readonly IShopOwnerRepository _shopOwnerRepository;
    private readonly IMapper _mapper;

    public ShopOwnerGetByIdQueryHandler(IShopOwnerRepository shopOwnerRepository, IMapper mapper)
    {
        _shopOwnerRepository = shopOwnerRepository;
        _mapper = mapper;
    }

    public async Task<Result<ShopOwnerDto>> Handle(ShopOwnerGetByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _shopOwnerRepository.GetByIdAsync(request.Id);
        if (entity == null)
            return Result<ShopOwnerDto>.NotFoundResult(request.Id);

        return Result<ShopOwnerDto>.SuccessResult(_mapper.Map<ShopOwnerDto>(entity));
    }
}