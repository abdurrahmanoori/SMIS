using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Queries;

public record UnitOfMeasureQuery(EntityDropdown<UnitOfMeasureQueryCriteria> Query)
    : IRequest<Result<PagedListNew<UnitOfMeasureDto>>>;

internal sealed class UnitOfMeasureQueryHandler
    : IRequestHandler<UnitOfMeasureQuery, Result<PagedListNew<UnitOfMeasureDto>>>
{
    private readonly IApplicationDbContext _context;

    public UnitOfMeasureQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<UnitOfMeasureDto>>> Handle(
        UnitOfMeasureQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.UnitOfMeasures
            .OrderBy(unit => unit.Name)
            .Select(unit => new UnitOfMeasureDto
            {
                Id = unit.Id,
                Name = unit.Name,
                Symbol = unit.Symbol,
                Description = unit.Description,
                ClientModifiedDate = unit.ClientModifiedDate,
                LastModifiedUtc = unit.LastModifiedUtc,
                IsDeleted = unit.IsDeleted
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<UnitOfMeasureDto>>.SuccessResult(pagedList);
    }
}