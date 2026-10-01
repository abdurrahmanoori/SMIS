using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Provinces.Queries;

public record ProvinceQuery(EntityDropdown<ProvinceQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ProvinceDto>>>;

internal sealed class ProvinceQueryHandler
    : IRequestHandler<ProvinceQuery, Result<PagedListNew<ProvinceDto>>>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUser _currentUser;

    public ProvinceQueryHandler(
        IApplicationDbContext context,
        ICurrentUser currentUser
    )
    {
        _context = context;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedListNew<ProvinceDto>>> Handle(
        ProvinceQuery request,
        CancellationToken cancellationToken
    )
    {
        var languageId = _currentUser.GetLangId();
        var query = _context.Provinces
            .Select(province => new ProvinceDto
            {
                Id = province.Id,
                Name = province.Translations
                           .Where(translation => translation.LanguageId == languageId)
                           .Select(translation => translation.Name)
                           .FirstOrDefault()
                       ?? province.Translations
                           .Where(translation => translation.IsDefault)
                           .Select(translation => translation.Name)
                           .FirstOrDefault()
                       ?? string.Empty
            })
            .OrderBy(province => province.Name);

        var pagedList = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ProvinceDto>>.Success(pagedList);
    }
}