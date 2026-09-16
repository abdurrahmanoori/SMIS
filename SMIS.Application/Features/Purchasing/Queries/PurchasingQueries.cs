using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Purchasing.Queries;

public sealed record SupplierGetListQuery : IRequest<Result<List<SupplierDto>>>;
public sealed record PurchaseOrderGetListQuery : IRequest<Result<List<PurchaseOrderDto>>>;
public sealed record PurchaseOrderGetByIdQuery(string Id) : IRequest<Result<PurchaseOrderDto>>;

internal sealed class PurchasingQueryHandler :
    IRequestHandler<SupplierGetListQuery, Result<List<SupplierDto>>>,
    IRequestHandler<PurchaseOrderGetListQuery, Result<List<PurchaseOrderDto>>>,
    IRequestHandler<PurchaseOrderGetByIdQuery, Result<PurchaseOrderDto>>
{
    private readonly IApplicationDbContext _db;

    public PurchasingQueryHandler(IApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<Result<List<SupplierDto>>> Handle(
        SupplierGetListQuery request,
        CancellationToken cancellationToken)
    {
        var suppliers = await _db.Suppliers
            .AsNoTracking()
            .OrderBy(supplier => supplier.Name)
            .ToListAsync(cancellationToken);

        return Result<List<SupplierDto>>.SuccessResult(
            suppliers.Select(Purchasing.Commands.PurchasingDtoMapper.ToDto).ToList());
    }

    public async Task<Result<List<PurchaseOrderDto>>> Handle(
        PurchaseOrderGetListQuery request,
        CancellationToken cancellationToken)
    {
        var orders = await OrderQuery()
            .AsNoTracking()
            .OrderByDescending(order => order.OrderedAtUtc)
            .ToListAsync(cancellationToken);

        return Result<List<PurchaseOrderDto>>.SuccessResult(
            orders.Select(Purchasing.Commands.PurchasingDtoMapper.ToDto).ToList());
    }

    public async Task<Result<PurchaseOrderDto>> Handle(
        PurchaseOrderGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        var order = await OrderQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.Id == request.Id, cancellationToken);

        return order is null
            ? Result<PurchaseOrderDto>.NotFoundResult(request.Id)
            : Result<PurchaseOrderDto>.SuccessResult(Purchasing.Commands.PurchasingDtoMapper.ToDto(order));
    }

    private IQueryable<SMIS.Domain.Entities.PurchaseOrder> OrderQuery() =>
        _db.PurchaseOrders
            .Include(order => order.Supplier)
            .Include(order => order.Lines)
                .ThenInclude(line => line.Product);
}
