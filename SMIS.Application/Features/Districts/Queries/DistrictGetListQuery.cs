using MediatR;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Queries
{
    public record DistrictGetListQuery(int PageNumber = 1, int PageSize = 25)
        : IRequest<Result<PagedList<DistrictDto>>>;

    internal sealed class
        DistrictGetListQueryHandler : IRequestHandler<DistrictGetListQuery, Result<PagedList<DistrictDto>>>
    {
        private readonly IDistrictRepository _districtRepository;
        public DistrictGetListQueryHandler(IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }

        public async Task<Result<PagedList<DistrictDto>>> Handle(
            DistrictGetListQuery request,
            CancellationToken cancellationToken
        )
        {
            var query = _districtRepository.GetAllQueryable()
                .Select(d => new DistrictDto
                {
                    Id = d.Id,
                    Name = d.Name
                });

            var pagedEntities = await query.ToPagedList(request.PageNumber, request.PageSize);
            if (pagedEntities.Items.Count == 0)
            {
                return Result<PagedList<DistrictDto>>.EmptyResult(nameof(DistrictDto));
            }

            return Result<PagedList<DistrictDto>>.SuccessResult(new PagedList<DistrictDto>
            {
                Items = pagedEntities.Items,
                TotalCount = pagedEntities.TotalCount,
                PageNumber = pagedEntities.PageNumber,
                PageSize = pagedEntities.PageSize
            });
        }
    }
}