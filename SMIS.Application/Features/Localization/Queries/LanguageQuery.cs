using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Localization.Queries;

public record LanguageQuery(EntityDropdown<LanguageQueryCriteria> Query)
    : IRequest<Result<PagedListNew<LanguageDto>>>;

internal sealed class LanguageQueryHandler
    : IRequestHandler<LanguageQuery, Result<PagedListNew<LanguageDto>>>
{
    private readonly IApplicationDbContext _context;

    public LanguageQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<LanguageDto>>> Handle(
        LanguageQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.Languages
            .OrderBy(language => language.Name)
            .Select(language => new LanguageDto
            {
                Id = language.Id,
                Name = language.Name,
                Code = language.Code,
                IsActive = language.IsActive
            });

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<LanguageDto>>.Success(pagedList);
    }
}