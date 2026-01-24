using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Queries
{
    public record TranslationGetByIdQuery(string Id) : IRequest<Result<TranslationEntityDto>>;

    internal sealed class TranslationGetByIdQueryHandler : IRequestHandler<TranslationGetByIdQuery, Result<TranslationEntityDto>>
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IMapper _mapper;

        public TranslationGetByIdQueryHandler(ITranslationRepository translationRepository, IMapper mapper)
        {
            _translationRepository = translationRepository;
            _mapper = mapper;
        }

        public async Task<Result<TranslationEntityDto>> Handle(TranslationGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbTranslation = await _translationRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbTranslation == null)
            {
                return Result<TranslationEntityDto>.NotFoundResult(nameof(TranslationEntityDto));
            }

            var translation = _mapper.Map<TranslationEntityDto>(dbTranslation);
            return Result<TranslationEntityDto>.SuccessResult(translation);
        }
    }
}