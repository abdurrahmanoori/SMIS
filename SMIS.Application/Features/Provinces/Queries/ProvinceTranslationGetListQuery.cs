using AutoMapper;
using MediatR;
//using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;
using System.Linq;

namespace SMIS.Application.Features.Provinces.Queries
{
    public record ProvinceTranslationGetListQuery(string ProvinceId) : IRequest<Result<List<ProvinceTranslationDto>>>;

    internal sealed class ProvinceTranslationGetListQueryHandler : IRequestHandler<ProvinceTranslationGetListQuery, Result<List<ProvinceTranslationDto>>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IMapper _mapper;

        public ProvinceTranslationGetListQueryHandler(IProvinceRepository repo, IMapper mapper)
        {
            _repo = repo; _mapper = mapper;
        }

        public async Task<Result<List<ProvinceTranslationDto>>> Handle(ProvinceTranslationGetListQuery request, CancellationToken cancellationToken)
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Id == request.ProvinceId, includeProperties: $"{nameof(Province.Translations)}.{nameof(ProvinceTranslation.Language)}");
            if (province is null) return Result<List<ProvinceTranslationDto>>.NotFoundResult(request.ProvinceId);

            var dto = _mapper.Map<List<ProvinceTranslationDto>>(province.Translations.ToList());
            return Result<List<ProvinceTranslationDto>>.SuccessResult(dto);
        }
    }
}
