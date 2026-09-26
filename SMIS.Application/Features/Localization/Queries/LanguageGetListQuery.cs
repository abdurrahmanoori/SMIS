using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Queries;

public record LanguageGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedListNew<LanguageDto>>>
{
}

internal sealed class
    LanguageGetListQueryHandler : IRequestHandler<LanguageGetListQuery, Result<PagedListNew<LanguageDto>>>
{
    private readonly ILanguageRepository _languageRepository;
    private readonly IMapper _mapper;

    public LanguageGetListQueryHandler(
        ILanguageRepository languageRepository,
        IMapper mapper
    )
    {
        _languageRepository = languageRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedListNew<LanguageDto>>> Handle(
        LanguageGetListQuery request,
        CancellationToken cancellationToken
    )
    {
        var query = _languageRepository.GetAllQueryable();
        var dtoQuery = query.ProjectTo<LanguageDto>(_mapper.ConfigurationProvider);

        var paged = await dtoQuery.ToPagedList(request.PageNumber, request.PageSize);
        if (paged.Items.Any() == false)
        {
            return Result<PagedListNew<LanguageDto>>.EmptyResult(nameof(LanguageDto));
        }

        return Result<PagedListNew<LanguageDto>>.SuccessResult(paged);
    }
}