using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Districts.Queries;

public record DistrictQuery(EntityDropdown<DistrictQueryCriteria> Query)
    : IRequest<Result<PagedListNew<DistrictDto>>>;

internal sealed class DistrictQueryHandler
    : IRequestHandler<DistrictQuery, Result<PagedListNew<DistrictDto>>>
{
    private readonly IApplicationDbContext _context;

    public DistrictQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<DistrictDto>>> Handle(
        DistrictQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Districts
            .OrderBy(district => district.Name)
            .Select(district => new DistrictDto
            {
                Id = district.Id,
                Name = district.Name
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<DistrictDto>>.SuccessResult(pagedList);
    }
}