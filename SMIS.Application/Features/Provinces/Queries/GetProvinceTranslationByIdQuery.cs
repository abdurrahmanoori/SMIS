using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Repositories.Provinces;

namespace SMIS.Application.Features.Provinces.Queries
{
    public record GetProvinceTranslationByIdQuery(int Id) : IRequest<Result<ProvinceTranslationDto>>;

    internal sealed class GetProvinceTranslationByIdQueryHandler : IRequestHandler<GetProvinceTranslationByIdQuery, Result<ProvinceTranslationDto>>
    {
        private readonly IProvinceRepository _repo;
        private readonly IMapper _mapper;

        public GetProvinceTranslationByIdQueryHandler(IProvinceRepository repo, IMapper mapper)
        {
            _repo = repo; _mapper = mapper;
        }

        public async Task<Result<ProvinceTranslationDto>> Handle(GetProvinceTranslationByIdQuery request, CancellationToken cancellationToken)
        {
            var province = await _repo.GetFirstOrDefaultAsync(x => x.Translations.Any(t => t.Id == request.Id), includeProperties: nameof(Domain.Entities.Province.Translations));
            if (province is null) return Result<ProvinceTranslationDto>.NotFoundResult(request.Id);

            var trans = province.Translations.FirstOrDefault(t => t.Id == request.Id);
            if (trans is null) return Result<ProvinceTranslationDto>.NotFoundResult(request.Id);

            var dto = _mapper.Map<ProvinceTranslationDto>(trans);
            return Result<ProvinceTranslationDto>.SuccessResult(dto);
        }
    }
}
