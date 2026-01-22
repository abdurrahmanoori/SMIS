using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Queries
{
    public record TranslationGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<TranslationEntityDto>>>;

    internal sealed class TranslationGetListQueryHandler : IRequestHandler<TranslationGetListQuery, Result<PagedList<TranslationEntityDto>>>
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IMapper _mapper;

        public TranslationGetListQueryHandler(ITranslationRepository translationRepository, IMapper mapper)
        {
            _translationRepository = translationRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<TranslationEntityDto>>> Handle(TranslationGetListQuery request, CancellationToken cancellationToken)
        {
            var translations = await _translationRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

            if (!translations.Items.Any())
            {
                return Result<PagedList<TranslationEntityDto>>.EmptyResult(nameof(TranslationEntityDto));
            }

            var translationDtos = _mapper.Map<List<TranslationEntityDto>>(translations.Items);

            return Result<PagedList<TranslationEntityDto>>.SuccessResult(new PagedList<TranslationEntityDto>
            {
                Items = translationDtos,
                TotalCount = translations.TotalCount,
                PageNumber = translations.PageNumber,
                PageSize = translations.PageSize,
                TotalPages = translations.TotalPages
            });
        }
    }
}