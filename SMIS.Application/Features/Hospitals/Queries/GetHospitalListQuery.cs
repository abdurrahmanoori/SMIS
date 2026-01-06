using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using SMIS.Application.DTO.Hospitals;
using SMIS.Application.Repositories.Hospitals;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;

namespace SMIS.Application.Features.Hospitals.Queries
{
    public record GetHospitalListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<HospitalDto>>>;

    internal sealed class GetHospitalListQueryHandler : IRequestHandler<GetHospitalListQuery, Result<PagedList<HospitalDto>>>
    {
        private readonly IHospitalRepository _repo;
        private readonly IMapper _mapper;

        public GetHospitalListQueryHandler(IHospitalRepository repo, IMapper mapper)
        { _repo = repo; _mapper = mapper; }

        public async Task<Result<PagedList<HospitalDto>>> Handle(GetHospitalListQuery request, CancellationToken cancellationToken)
        {
            var query = _repo.GetAllQueryable();
            var dtoQuery = query.ProjectTo<HospitalDto>(_mapper.ConfigurationProvider);

            var paged = await dtoQuery.ToPagedList(request.PageNumber, request.PageSize);
            if (paged.Items.Any() == false)
            {
                return Result<PagedList<HospitalDto>>.EmptyResult(nameof(HospitalDto));
            }

            return Result<PagedList<HospitalDto>>.SuccessResult(paged);
        }
    }
}
