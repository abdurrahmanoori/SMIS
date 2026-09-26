using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record DistrictGetByIdQuery(string Id) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictGetByIdQueryHandler : IRequestHandler<DistrictGetByIdQuery, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        public DistrictGetByIdQueryHandler(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictGetByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);

            if (entity == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto));
            }

            return Result<DistrictDto>.SuccessResult(new DistrictDto
            {
                Id = entity.Id,
                Name = entity.Name
            });
        }
    }
}