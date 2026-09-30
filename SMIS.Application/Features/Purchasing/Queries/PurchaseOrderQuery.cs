using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Purchasing.Queries;

public sealed record PurchaseOrderQuery(EntityDropdown<PurchaseOrderQueryCriteria> Query)
    : IRequest<Result<PagedListNew<PurchaseOrderDto>>>;

internal sealed class PurchaseOrderQueryHandler
    : IRequestHandler<PurchaseOrderQuery, Result<PagedListNew<PurchaseOrderDto>>>
{
    private readonly IApplicationDbContext _context;

    public PurchaseOrderQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<PurchaseOrderDto>>> Handle(
        PurchaseOrderQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.PurchaseOrders
            .OrderByDescending(order => order.OrderedAtUtc)
            .ThenBy(order => order.Id)
            .Select(order => new PurchaseOrderDto
            {
                Id = order.Id,
                ShopId = order.ShopId,
                SupplierId = order.SupplierId,
                SupplierName = _context.Suppliers
                    .Where(supplier => supplier.Id == order.SupplierId)
                    .Select(supplier => supplier.Name)
                    .FirstOrDefault() ?? string.Empty,
                ReferenceNumber = order.ReferenceNumber,
                OrderedAtUtc = order.OrderedAtUtc,
                Status = order.Status,
                Notes = order.Notes,
                Lines = order.Lines
                    .OrderBy(line => line.Id)
                    .Select(line => new PurchaseOrderLineDto
                    {
                        Id = line.Id,
                        ProductId = line.ProductId,
                        ProductName = _context.Products
                            .Where(product => product.Id == line.ProductId)
                            .Select(product => product.Name)
                            .FirstOrDefault() ?? string.Empty,
                        ProductUnitId = line.ProductUnitId,
                        OrderedQuantityEntered = line.OrderedQuantityEntered,
                        ReceivedQuantityEntered = line.ReceivedQuantityEntered,
                        ReturnedQuantityEntered = line.ReturnedQuantityEntered,
                        RemainingToReceiveQuantityEntered =
                            line.OrderedQuantityEntered - line.ReceivedQuantityEntered,
                        NetReceivedQuantityEntered =
                            line.ReceivedQuantityEntered - line.ReturnedQuantityEntered,
                        UnitCostBase = line.UnitCostBase
                    })
                    .ToList()
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<PurchaseOrderDto>>.SuccessResult(page);
    }
}