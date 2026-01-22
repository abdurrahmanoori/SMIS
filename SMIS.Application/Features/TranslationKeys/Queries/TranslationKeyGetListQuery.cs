using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.TranslationKeys.Queries
{
    public record TranslationKeyGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<TranslationKeyDto>>>;

    internal sealed class TranslationKeyGetListQueryHandler : IRequestHandler<TranslationKeyGetListQuery, Result<PagedList<TranslationKeyDto>>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IMapper _mapper;

        public TranslationKeyGetListQueryHandler(ITranslationKeyRepository translationKeyRepository, IMapper mapper)
        {
            _translationKeyRepository = translationKeyRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<TranslationKeyDto>>> Handle(TranslationKeyGetListQuery request, CancellationToken cancellationToken)
        {
            var translationKeys = await _translationKeyRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

            if (!translationKeys.Items.Any())
            {
                return Result<PagedList<TranslationKeyDto>>.EmptyResult(nameof(TranslationKeyDto));
            }

            var translationKeyDtos = _mapper.Map<List<TranslationKeyDto>>(translationKeys.Items);

            return Result<PagedList<TranslationKeyDto>>.SuccessResult(new PagedList<TranslationKeyDto>
            {
                Items = translationKeyDtos,
                TotalCount = translationKeys.TotalCount,
                PageNumber = translationKeys.PageNumber,
                PageSize = translationKeys.PageSize,
                TotalPages = translationKeys.TotalPages
            });
        }
    }
}