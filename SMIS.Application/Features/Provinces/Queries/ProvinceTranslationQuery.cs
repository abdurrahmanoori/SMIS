using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Services;

namespace SMIS.Application.Features.Provinces.Queries;

public sealed record ProvinceTranslationQuery(EntityDropdown<ProvinceTranslationQueryCriteria> Query)
    : IRequest<Result<PagedListNew<ProvinceTranslationDto>>>;

internal sealed class ProvinceTranslationQueryHandler
    : IRequestHandler<ProvinceTranslationQuery, Result<PagedListNew<ProvinceTranslationDto>>>
{
    private readonly IApplicationDbContext _context;

    public ProvinceTranslationQueryHandler(
        IApplicationDbContext context
    )
    {
        _context = context;
    }

    public async Task<Result<PagedListNew<ProvinceTranslationDto>>> Handle(
        ProvinceTranslationQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _context.ProvinceTranslations
            .OrderBy(translation => translation.Name)
            .Select(translation => new ProvinceTranslationDto
            {
                Id = translation.Id,
                ProvinceId = translation.ProvinceId,
                LanguageCode = translation.LanguageCode,
                LanguageId = translation.LanguageId,
                IsDefault = translation.IsDefault,
                Name = translation.Name
            });

        var page = await query
            .Filter(request.Query.Criteria)
            .Select(request.Query.Columns)
            .ToPagedList(
                request.Query.GetPageNumber(),
                request.Query.GetPageSize(),
                cancellationToken);

        return Result<PagedListNew<ProvinceTranslationDto>>.SuccessResult(page);
    }
}