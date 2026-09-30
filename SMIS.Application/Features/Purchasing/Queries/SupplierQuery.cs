using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Purchasing;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Purchasing.Queries;

public sealed record SupplierQuery(EntityDropdown<SupplierQueryCriteria> Query)
    : IRequest<Result<PagedListNew<SupplierDto>>>;

internal sealed class SupplierQueryHandler
    : IRequestHandler<SupplierQuery, Result<PagedListNew<SupplierDto>>>
{
    private readonly IApplicationDbContext _context;

    public SupplierQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<SupplierDto>>> Handle(
        SupplierQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Suppliers
            .OrderBy(supplier => supplier.Name)
            .Select(supplier => new SupplierDto
            {
                Id = supplier.Id,
                ShopId = supplier.ShopId,
                Name = supplier.Name,
                PhoneNumber = supplier.PhoneNumber,
                Notes = supplier.Notes,
                IsActive = supplier.IsActive
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<SupplierDto>>.SuccessResult(page);
    }
}