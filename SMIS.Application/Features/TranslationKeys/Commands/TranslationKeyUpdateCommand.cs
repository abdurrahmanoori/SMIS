using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.TranslationKeys.Commands
{
    public record TranslationKeyUpdateCommand(string Id, TranslationKeyCreateDto TranslationKeyCreateDto) : IRequest<Result<TranslationKeyDto>>;

    internal sealed class TranslationKeyUpdateCommandHandler : IRequestHandler<TranslationKeyUpdateCommand, Result<TranslationKeyDto>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TranslationKeyUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<TranslationKeyDto>> Handle(TranslationKeyUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _translationKeyRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id, 
                includeProperties: "Translations");
                
            if (entity == null)
            {
                return Result<TranslationKeyDto>.NotFoundResult(nameof(TranslationKeyDto.Id));
            }

            // Update basic properties

            // Update translations if provided
            //if (request.TranslationKeyCreateDto.Translations?.Any() == true)
            //{
            //    // Clear existing translations
            //    entity.Translations.Clear();

            //    // Add new translations
            //    var newTranslations = _mapper.Map<List<Translation>>(request.TranslationKeyCreateDto.Translations);
            //    foreach (var translation in newTranslations)
            //    {
            //        translation.TranslationKeyId = entity.Id;
            //        entity.Translations.Add(translation);
            //    }
            //}
            _mapper.Map(request.TranslationKeyCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<TranslationKeyDto>(entity);
            return Result<TranslationKeyDto>.SuccessResult(dto);
        }
    }
}