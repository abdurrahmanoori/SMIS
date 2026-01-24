using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Queries
{
    public record ProvinceGetByIdQuery(string Id) : IRequest<Result<ProvinceDto>>;

    internal sealed class ProvinceGetByIdQueryHandler : IRequestHandler<ProvinceGetByIdQuery, Result<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICurrentUser _currentUser;

        public ProvinceGetByIdQueryHandler(IProvinceRepository provinceRepository, ICurrentUser currentUser)
        {
            _provinceRepository = provinceRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<ProvinceDto>> Handle(ProvinceGetByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _provinceRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id, includeProperties: nameof(Province.Translations));
            if (entity is null)
            {
                return Result<ProvinceDto>.NotFoundResult(request.Id);
            }

            var userLangId = _currentUser.GetLangId();
            var translation = entity.Translations.FirstOrDefault(t => t.LanguageId == userLangId) ??
                             entity.Translations.FirstOrDefault(t => t.IsDefault);

            var dto = new ProvinceDto
            {
                Id = entity.Id,
                Name = translation?.Name ?? string.Empty
            };

            return Result<ProvinceDto>.SuccessResult(dto);
        }
    }
}
