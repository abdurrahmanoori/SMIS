using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Localization;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Application.Mappings;

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
            var entity = request.LanguageCreateDto.ToEntity();
            await _languageRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            var dto = entity.ToDto();
            return Result<LanguageDto>.Success(dto);
        }
    }
}