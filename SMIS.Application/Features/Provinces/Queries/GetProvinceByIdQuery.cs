using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Provinces;

namespace SMIS.Application.Features.Provinces.Queries
{
    public record GetProvinceByIdQuery(string PublicId) : IRequest<Result<ProvinceDto>>;

    internal sealed class GetProvinceByIdQueryHandler : IRequestHandler<GetProvinceByIdQuery, Result<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICurrentUser _currentUser;

        public GetProvinceByIdQueryHandler(IProvinceRepository provinceRepository, ICurrentUser currentUser)
        {
            _provinceRepository = provinceRepository;
            _currentUser = currentUser;
        }

        public async Task<Result<ProvinceDto>> Handle(GetProvinceByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _provinceRepository.GetFirstOrDefaultAsync(x => x.PublicId == request.PublicId, includeProperties: nameof(Domain.Entities.Province.Translations));
            if (entity is null)
            {
                return Result<ProvinceDto>.NotFoundResult(request.PublicId);
            }

            var userLangId = _currentUser.GetLangId();
            var translation = entity.Translations.FirstOrDefault(t => t.LanguageId == userLangId) ??
                             entity.Translations.FirstOrDefault(t => t.IsDefault);

            var dto = new ProvinceDto
            {
                PublicId = entity.PublicId,
                Name = translation?.Name ?? string.Empty
            };

            return Result<ProvinceDto>.SuccessResult(dto);
        }
    }
}
