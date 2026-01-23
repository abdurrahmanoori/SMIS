using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.TranslationKeys.Commands
{
    public record TranslationKeyCreateCommand(TranslationKeyCreateDto TranslationKeyCreateDto) : IRequest<Result<TranslationKeyCreateDto>>;

    internal sealed class TranslationKeyCreateCommandHandler : IRequestHandler<TranslationKeyCreateCommand, Result<TranslationKeyCreateDto>>
    {
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TranslationKeyCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<TranslationKeyCreateDto>> Handle(TranslationKeyCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TranslationKey>(request.TranslationKeyCreateDto);
            
            //// Map nested translations
            //if (request.TranslationKeyCreateDto.Translations?.Any() == true)
            //{
            //    entity.Translations = _mapper.Map<List<Translation>>(request.TranslationKeyCreateDto.Translations);
            //    foreach (var translation in entity.Translations)
            //    {
            //        translation.TranslationKeyId = entity.Id;
            //    }
            //}
            
            await _translationKeyRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<TranslationKeyCreateDto>.SuccessResult(_mapper.Map<TranslationKeyCreateDto>(entity));
        }
    }
}