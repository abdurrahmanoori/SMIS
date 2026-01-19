using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record GetDistrictListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<DistrictDto>>>;

    internal sealed class GetDistrictListQueryHandler : IRequestHandler<GetDistrictListQuery, Result<PagedList<DistrictDto>>>
    {
        private readonly IDistrictRepository _districtRepository;

        public GetDistrictListQueryHandler(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public async Task<Result<PagedList<DistrictDto>>> Handle(GetDistrictListQuery request, CancellationToken cancellationToken)
        {
            var query = _districtRepository.GetAllQueryable()
                .Select(d => new DistrictDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    PublicId = d.PublicId,
                });

            var pagedEntities = await query.ToPagedList(request.PageNumber, request.PageSize);
            if (pagedEntities.Items.Count == 0)
            {
                return Result<PagedList<DistrictDto>>.EmptyResult(nameof(DistrictDto));
            }

            return Result<PagedList<DistrictDto>>.SuccessResult(pagedEntities);
        }
    }
}