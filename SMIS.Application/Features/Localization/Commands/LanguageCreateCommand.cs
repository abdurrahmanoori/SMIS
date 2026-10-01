using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Features.Localization;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;

namespace SMIS.Application.Features.Localization.Commands
{
    public record LanguageCreateCommand(LanguageCreateDto LanguageCreateDto) : IRequest<Result<LanguageDto>>
    {
    }

    internal sealed class LanguageCreateCommandHandler : IRequestHandler<LanguageCreateCommand, Result<LanguageDto>>
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LanguageCreateCommandHandler(
            IUnitOfWork unitOfWork,
            ILanguageRepository languageRepository
        )
        {
            _unitOfWork = unitOfWork;
            _languageRepository = languageRepository;
        }

        public async Task<Result<LanguageDto>> Handle(
            LanguageCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = LanguageMapping.Create(request.LanguageCreateDto);
            await _languageRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<LanguageDto>.SuccessResult(LanguageMapping.ToDto(entity));
        }
    }
}
