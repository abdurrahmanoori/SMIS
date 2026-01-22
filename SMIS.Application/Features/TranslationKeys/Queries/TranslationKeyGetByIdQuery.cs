using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.TranslationKeys.Queries
{
    public record TranslationKeyGetByIdQuery(string Id) : IRequest<Result<TranslationKeyDto>>;

    internal sealed class TranslationKeyGetByIdQueryHandler : IRequestHandler<TranslationKeyGetByIdQuery, Result<TranslationKeyDto>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IMapper _mapper;

        public TranslationKeyGetByIdQueryHandler(ITranslationKeyRepository translationKeyRepository, IMapper mapper)
        {
            _translationKeyRepository = translationKeyRepository;
            _mapper = mapper;
        }

        public async Task<Result<TranslationKeyDto>> Handle(TranslationKeyGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbTranslationKey = await _translationKeyRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbTranslationKey == null)
            {
                return Result<TranslationKeyDto>.NotFoundResult(nameof(TranslationKeyDto));
            }

            var translationKey = _mapper.Map<TranslationKeyDto>(dbTranslationKey);
            return Result<TranslationKeyDto>.SuccessResult(translationKey);
        }
    }
}