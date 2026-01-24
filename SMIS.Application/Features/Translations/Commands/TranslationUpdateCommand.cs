using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Translations.Commands
{
    public record TranslationUpdateCommand(string Id, TranslationEntityCreateDto TranslationCreateDto) : IRequest<Result<TranslationEntityDto>>;

    internal sealed class TranslationUpdateCommandHandler : IRequestHandler<TranslationUpdateCommand, Result<TranslationEntityDto>>
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TranslationUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ITranslationRepository translationRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _translationRepository = translationRepository;
        }

        public async Task<Result<TranslationEntityDto>> Handle(TranslationUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _translationRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<TranslationEntityDto>.NotFoundResult(nameof(TranslationEntityDto.Id));
            }

            _mapper.Map(request.TranslationCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<TranslationEntityDto>(entity);
            return Result<TranslationEntityDto>.SuccessResult(dto);
        }
    }
}