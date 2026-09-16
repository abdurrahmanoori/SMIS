using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Inventory;
using SMIS.Application.Features.Inventory.Commands;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Inventory.Queries;

public sealed record StockCountGetByIdQuery(string Id)
    : IRequest<Result<StockCountSessionDto>>;

internal sealed class StockCountGetByIdQueryHandler
    : IRequestHandler<StockCountGetByIdQuery, Result<StockCountSessionDto>>
{
    private readonly IApplicationDbContext _db;

    public StockCountGetByIdQueryHandler(IApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<Result<StockCountSessionDto>> Handle(
        StockCountGetByIdQuery request,
        CancellationToken cancellationToken)
    {
        var session = await _db.StockCountSessions
            .AsNoTracking()
            .Include(item => item.Lines)
                .ThenInclude(line => line.StockBatch)
                    .ThenInclude(batch => batch.Product)
            .FirstOrDefaultAsync(item => item.Id == request.Id, cancellationToken);

        if (session is null)
            return Result<StockCountSessionDto>.NotFoundResult(request.Id);

        return Result<StockCountSessionDto>.SuccessResult(
            StockCountDtoMapper.ToDto(
                session,
                session.Lines.Select(line => line.StockBatch).ToList()));
    }
}


