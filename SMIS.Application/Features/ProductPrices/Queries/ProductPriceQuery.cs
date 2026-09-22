using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.ProductPrices.Queries;

public sealed class ProductPriceQueryCriteria
{
    public string? Id { get; set; }
    public string? ProductUnitId { get; set; }
    public long? SellPrice { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public DateTime? EndDate { get; set; }
}

public record ProductPriceQuery(EntityDropdown<ProductPriceQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ProductPriceDto>>>;

internal sealed class ProductPriceQueryHandler
    : IRequestHandler<ProductPriceQuery, Result<PagedListNew<ProductPriceDto>>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public ProductPriceQueryHandler(
        IApplicationDbContext context,
        ICurrentUser currentUser
    ) => (_context, _currentUser) = (context, currentUser);

    public async Task<Result<PagedListNew<ProductPriceDto>>> Handle(
        ProductPriceQuery request,
        CancellationToken cancellationToken
    )
    {
        var shopId = _currentUser.GetShopId();
        var query = _context.ProductPrices
            .Where(x => x.ProductUnit.Product.ShopId == shopId)
            .OrderByDescending(x => x.EffectiveDate)
            .Select(x => new ProductPriceDto
            {
                Id = x.Id,
                ProductUnitId = x.ProductUnitId,
                SellPrice = x.SellPrice,
                EffectiveDate = x.EffectiveDate,
                EndDate = x.EndDate,
                ClientCreatedDate = x.ClientCreatedDate,
                ClientCreatedBy = x.ClientCreatedBy,
                ClientModifiedDate = x.ClientModifiedDate,
                ClientModifiedBy = x.ClientModifiedBy,
                LastModifiedUtc = x.LastModifiedUtc,
                IsDeleted = x.IsDeleted,
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        foreach (var item in pagedList.Items)
        {
            item.ConflictModifiedUtc = DateTimeService.NormalizeUtc(
                item.ClientModifiedDate
                ?? item.ClientCreatedDate
                ?? item.LastModifiedUtc);
        }

        return Result<PagedListNew<ProductPriceDto>>.SuccessResult(pagedList);
    }
}
