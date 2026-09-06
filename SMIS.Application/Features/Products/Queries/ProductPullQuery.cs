using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Products.Queries;

public record ProductPullQuery(DateTime ChangedSince) : IRequest<Result<List<ProductDto>>>;

internal sealed class ProductPullQueryHandler : IRequestHandler<ProductPullQuery, Result<List<ProductDto>>>
{
    private readonly IProductRepository _repository;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public ProductPullQueryHandler(
        IProductRepository repository,
        ICurrentUser currentUser,
        IMapper mapper
    ) => (_repository, _currentUser, _mapper) = (repository, currentUser, mapper);

    public async Task<Result<List<ProductDto>>> Handle(
        ProductPullQuery request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        var isSuperAdmin = _currentUser.IsSuperAdmin();
        var since = DateTimeService.NormalizeUtc(request.ChangedSince);
        var products =
            await _repository.GetAllAsync(p => p.LastModifiedUtc > since && (isSuperAdmin || p.ShopId == shopId),
                ignoreQueryFilters: true);
        return Result<List<ProductDto>>.SuccessResult(_mapper.Map<List<ProductDto>>(products));
    }
}