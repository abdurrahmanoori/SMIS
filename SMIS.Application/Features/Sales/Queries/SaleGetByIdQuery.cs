using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Repositories.Sales;

namespace SMIS.Application.Features.Sales.Queries;

public sealed record SaleGetByIdQuery(string Id) : IRequest<Result<SaleDto>>;

internal sealed class SaleGetByIdQueryHandler : IRequestHandler<SaleGetByIdQuery, Result<SaleDto>>
{
    private readonly ISaleRepository _sales;
    private readonly IMapper _mapper;

    public SaleGetByIdQueryHandler(
        ISaleRepository sales,
        IMapper mapper
    )
    {
        _sales = sales;
        _mapper = mapper;
    }

    public async Task<Result<SaleDto>> Handle(
        SaleGetByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        var sale = await _sales.GetByIdWithDetailsAsync(request.Id, cancellationToken);
        if (sale is null)
            return Result<SaleDto>.NotFoundResult(request.Id);

        var dto = _mapper.Map<SaleDto>(sale);
        dto.ReceivableId = sale.Receivable?.Id;
        dto.ReceivableRemainingAmount = sale.Receivable?.RemainingAmount;
        return Result<SaleDto>.SuccessResult(dto);
    }
}