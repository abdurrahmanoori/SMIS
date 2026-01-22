using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.TranslationKeys;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

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
            var entity = await _translationKeyRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<TranslationKeyDto>.NotFoundResult(nameof(TranslationKeyDto.Id));
            }

            _mapper.Map(request.TranslationKeyCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<TranslationKeyDto>(entity);
            return Result<TranslationKeyDto>.SuccessResult(dto);
        }
    }
}