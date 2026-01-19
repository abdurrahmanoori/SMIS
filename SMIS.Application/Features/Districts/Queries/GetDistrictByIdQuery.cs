using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record GetDistrictByIdQuery(int Id) : IRequest<Result<DistrictDto>>;

    internal sealed class GetDistrictByIdQueryHandler : IRequestHandler<GetDistrictByIdQuery, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;

        public GetDistrictByIdQueryHandler(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(GetDistrictByIdQuery request, CancellationToken cancellationToken)
        {
            var district = await _districtRepository.GetByIdAsync(request.Id);
            if (district == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto));
            }

            var dto = new DistrictDto
            {
                Id = district.Id,
                Name = district.Name,
                TranslationKeyId = district.TranslationKeyId
            };

            return Result<DistrictDto>.SuccessResult(dto);
        }
    }
}