using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Shops;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Shops.Queries;

public record ShopQuery(EntityDropdown<ShopQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ShopDto>>>;

internal sealed class ShopQueryHandler
    : IRequestHandler<ShopQuery, Result<PagedListNew<ShopDto>>>
{
    private readonly IApplicationDbContext _context;

    public ShopQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<ShopDto>>> Handle(
        ShopQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Shops
            .OrderBy(shop => shop.Name)
            .Select(shop => new ShopDto
            {
                Id = shop.Id,
                Name = shop.Name,
                ShopType = shop.ShopType,
                Address = shop.Address,
                PhoneNumber = shop.PhoneNumber,
                Email = shop.Email,
                TaxNumber = shop.TaxNumber,
                IsActive = shop.IsActive,
                LastModifiedUtc = shop.LastModifiedUtc,
                IsDeleted = shop.IsDeleted,
                ClientModifiedDate = shop.ClientModifiedDate
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ShopDto>>.SuccessResult(pagedList);
    }
}