using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Translations;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;

namespace SMIS.Application.Features.Translations.Commands
{
    public record TranslationCreateCommand(TranslationEntityCreateDto TranslationCreateDto) : IRequest<Result<TranslationEntityDto>>;

    internal sealed class TranslationCreateCommandHandler : IRequestHandler<TranslationCreateCommand, Result<TranslationEntityDto>>
    {
        private readonly ITranslationRepository _translationRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TranslationCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ITranslationRepository translationRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _translationRepository = translationRepository;
        }

        public async Task<Result<TranslationEntityDto>> Handle(TranslationCreateCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Translation>(request.TranslationCreateDto);
            await _translationRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<TranslationEntityDto>.SuccessResult(_mapper.Map<TranslationEntityDto>(entity));
        }
    }
}