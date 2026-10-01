using MediatR;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces;
using SMIS.Application.Repositories.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Common.Response;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceTranslationUpdateCommand(string Id, ProvinceTranslationDto Dto)
        : IRequest<Result<ProvinceTranslationDto>>;

    internal sealed class
        ProvinceTranslationUpdateCommandHandler : IRequestHandler<ProvinceTranslationUpdateCommand,
        Result<ProvinceTranslationDto>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly ILanguageRepository _languageRepo;

        public ProvinceTranslationUpdateCommandHandler(
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
            ProvinceTranslationUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Translations.Any(t => t.Id == request.Id),
                includeProperties: nameof(Province.Translations));
            if (province is null) return Result<ProvinceTranslationDto>.NotFound(request.Id);

            var trans = province.Translations.FirstOrDefault(t => t.Id == request.Id);
            if (trans is null) return Result<ProvinceTranslationDto>.NotFound(request.Id);

            ProvinceTranslationMapping.Apply(trans, request.Dto);

            if (!string.IsNullOrEmpty(request.Dto.LanguageId))
            {
                trans.LanguageId = request.Dto.LanguageId;
            }
            else if (!string.IsNullOrWhiteSpace(request.Dto.LanguageCode))
            {
                var lang = await _languageRepo.GetFirstOrDefaultAsync(x => x.Code == request.Dto.LanguageCode);
                if (lang != null) trans.LanguageId = lang.Id;
            }

            trans.LanguageCode = request.Dto.LanguageCode;

            await _uow.SaveChanges(cancellationToken);

            return Result<ProvinceTranslationDto>.Success(ProvinceTranslationMapping.ToDto(trans));
        }
    }
}
