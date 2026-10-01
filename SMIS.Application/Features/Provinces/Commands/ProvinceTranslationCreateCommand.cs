using MediatR;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Provinces;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceTranslationCreateCommand(ProvinceTranslationDto Dto)
        : IRequest<Result<ProvinceTranslationDto>>;

    internal sealed class
        ProvinceTranslationCreateCommandHandler : IRequestHandler<ProvinceTranslationCreateCommand,
        Result<ProvinceTranslationDto>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly ILanguageRepository _languageRepo;

        public ProvinceTranslationCreateCommandHandler(
            IProvinceRepository repo,
            IUnitOfWork uow,
            ILanguageRepository languageRepo
        )
        {
            _repo = repo;
            _uow = uow;
            _languageRepo = languageRepo;
        }

        public async Task<Result<ProvinceTranslationDto>> Handle(
            ProvinceTranslationCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var province = await _repo.GetByIdAsync(request.Dto.ProvinceId);
            if (province is null) return Result<ProvinceTranslationDto>.NotFoundResult(request.Dto.ProvinceId);

            var entity = ProvinceTranslationMapping.Create(request.Dto);

            if (string.IsNullOrEmpty(request.Dto.LanguageId) && !string.IsNullOrWhiteSpace(request.Dto.LanguageCode))
            {
                var lang = await _languageRepo.GetFirstOrDefaultAsync(x => x.Code == request.Dto.LanguageCode);
                if (lang != null)
                {
                    entity.LanguageId = lang.Id;
                }
                else
                {
                    return Result<ProvinceTranslationDto>.FailureResult(
                        $"Language with code '{request.Dto.LanguageCode}' not found");
                }
            }
            else if (!string.IsNullOrEmpty(request.Dto.LanguageId))
            {
                var lang = await _languageRepo.GetByIdAsync(request.Dto.LanguageId);
                if (lang == null)
                {
                    return Result<ProvinceTranslationDto>.FailureResult(
                        $"Language with ID '{request.Dto.LanguageId}' not found");
                }

                entity.LanguageId = request.Dto.LanguageId;
            }
            else
            {
                return Result<ProvinceTranslationDto>.FailureResult(
                    "Either LanguageId or LanguageCode must be provided");
            }

            entity.LanguageCode = request.Dto.LanguageCode;
            province.Translations ??= new List<ProvinceTranslation>();
            province.Translations.Add(entity);

            await _uow.SaveChanges(cancellationToken);

            return Result<ProvinceTranslationDto>.SuccessResult(ProvinceTranslationMapping.ToDto(entity));
        }
    }
}
