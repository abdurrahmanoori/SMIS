using AutoMapper;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Sales;
using SMIS.Application.Identity.IServices;

namespace SMIS.Application.Features.Sales.Queries;

public sealed record SaleGetListQuery(int PageNumber = 1, int PageSize = 25)
    : IRequest<Result<PagedList<SaleDto>>>;

internal sealed class SaleGetListQueryHandler : IRequestHandler<SaleGetListQuery, Result<PagedList<SaleDto>>>
{
    private readonly ISaleRepository _sales;
    private readonly IMapper _mapper;
    private readonly ICurrentUser _currentUser;

    public SaleGetListQueryHandler(
        ISaleRepository sales,
        IMapper mapper,
        ICurrentUser currentUser
    )
    {
        _sales = sales;
        _mapper = mapper;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedList<SaleDto>>> Handle(
        SaleGetListQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _sales.GetAllQueryable(includeProperties: "Lines,Receivable.Payments");
        var shopId = _currentUser.GetShopId();
        query = query.Where(sale => sale.ShopId == shopId);

        var page = await query
            .ToPagedList(request.PageNumber, request.PageSize);

        if (!page.Items.Any())
            return Result<PagedList<SaleDto>>.EmptyResult(nameof(SaleDto));

        var items = page.Items.Select(sale =>
        {
            var dto = _mapper.Map<SaleDto>(sale);
            dto.ReceivableId = sale.Receivable?.Id;
            dto.ReceivableRemainingAmount = sale.Receivable?.RemainingAmount;
            return dto;
        }).ToList();

        return Result<PagedList<SaleDto>>.SuccessResult(new PagedList<SaleDto>
        {
            Items = items,
            PageNumber = page.PageNumber,
            PageSize = page.PageSize,
            TotalCount = page.TotalCount,
            TotalPages = page.TotalPages
        });
    }
}