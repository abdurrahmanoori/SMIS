using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Queries;

public record LanguageGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<LanguageDto>>> { }

internal sealed class LanguageGetListQueryHandler : IRequestHandler<LanguageGetListQuery, Result<PagedList<LanguageDto>>>
{
    private readonly ILanguageRepository _languageRepository;
    private readonly IMapper _mapper;

    public LanguageGetListQueryHandler(ILanguageRepository languageRepository, IMapper mapper)
    {
        _languageRepository = languageRepository;
        _mapper = mapper;
    }

    public async Task<Result<PagedList<LanguageDto>>> Handle(LanguageGetListQuery request, CancellationToken cancellationToken)
    {
        var query = _languageRepository.GetAllQueryable();
        var dtoQuery = query.ProjectTo<LanguageDto>(_mapper.ConfigurationProvider);

        var paged = await dtoQuery.ToPagedList(request.PageNumber, request.PageSize);
        if (paged.Items.Any() == false)
        {
            return Result<PagedList<LanguageDto>>.EmptyResult(nameof(LanguageDto));
        }

        return Result<PagedList<LanguageDto>>.SuccessResult(paged);
    }
}
