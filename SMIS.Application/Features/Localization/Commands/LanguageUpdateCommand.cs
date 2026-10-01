using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Localization;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Commands
{
    public record LanguageUpdateCommand(string Id, LanguageCreateDto LanguageCreateDto) : IRequest<Result<LanguageDto>>
    {
    }

    internal sealed class LanguageUpdateCommandHandler : IRequestHandler<LanguageUpdateCommand, Result<LanguageDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LanguageUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            ILanguageRepository languageRepository
        )
        {
            _unitOfWork = unitOfWork;
            _languageRepository = languageRepository;
        }

        public async Task<Result<LanguageDto>> Handle(
            LanguageUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _languageRepository.GetByIdAsync(request.Id);
            if (entity is null)
            {
                return Result<LanguageDto>.NotFoundResult(request.Id);
            }

            LanguageMapping.Apply(entity, request.LanguageCreateDto);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<LanguageDto>.SuccessResult(LanguageMapping.ToDto(entity));
        }
    }
}
