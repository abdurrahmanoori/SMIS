using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Mappings;

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
                return Result<LanguageDto>.NotFound(request.Id);
            }

            request.LanguageCreateDto.ApplyTo(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            var dto = entity.ToDto();
            return Result<LanguageDto>.Success(dto);
        }
    }
}