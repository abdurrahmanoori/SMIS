using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Repositories.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.DTO.Common.Response;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record UpdateProvinceTranslationCommand(Guid Id, ProvinceTranslationDto Dto) : IRequest<Result<ProvinceTranslationDto>>;

    internal sealed class UpdateProvinceTranslationCommandHandler : IRequestHandler<UpdateProvinceTranslationCommand, Result<ProvinceTranslationDto>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _languageRepo;

        public UpdateProvinceTranslationCommandHandler(IProvinceRepository repo, IUnitOfWork uow, IMapper mapper, ILanguageRepository languageRepo)
        {
            _repo = repo; _uow = uow; _mapper = mapper; _languageRepo = languageRepo;
        }

        public async Task<Result<ProvinceTranslationDto>> Handle(UpdateProvinceTranslationCommand request, CancellationToken cancellationToken)
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Translations.Any(t => t.Id == request.Id), includeProperties: nameof(Province.Translations));
            if (province is null) return Result<ProvinceTranslationDto>.NotFoundResult(request.Id);

            var trans = province.Translations.FirstOrDefault(t => t.Id == request.Id);
            if (trans is null) return Result<ProvinceTranslationDto>.NotFoundResult(request.Id);

            // Map incoming values onto the tracked entity
            _mapper.Map(request.Dto, trans);

            // Resolve language id if provided or by code
            if (request.Dto.LanguageId != Guid.Empty)
            {
                trans.LanguageId = request.Dto.LanguageId;
            }
            else if (!string.IsNullOrWhiteSpace(request.Dto.LanguageCode))
            {
                var lang = await _languageRepo.GetFirstOrDefaultAsync(x => x.Code == request.Dto.LanguageCode);
                if (lang != null) trans.LanguageId = lang.Id;
            }

            // Ensure LanguageCode is synced
            trans.LanguageCode = request.Dto.LanguageCode;

            await _uow.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProvinceTranslationDto>(trans);
            return Result<ProvinceTranslationDto>.SuccessResult(dto);
        }
    }
}
