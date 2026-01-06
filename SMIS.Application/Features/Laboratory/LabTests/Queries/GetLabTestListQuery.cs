using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using SMIS.Application.DTO.Common;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Laboratory;
using SMIS.Application.Repositories.Laboratory;

namespace SMIS.Application.Features.Laboratory.LabTests.Queries
{
    public record GetLabTestListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<LabTestDto>>>;

    internal sealed class GetLabTestListQueryHandler : IRequestHandler<GetLabTestListQuery, Result<PagedList<LabTestDto>>>
    {
        private readonly ILabTestRepository _repo;
        private readonly IMapper _mapper;

        public GetLabTestListQueryHandler(ILabTestRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<LabTestDto>>> Handle(GetLabTestListQuery request, CancellationToken cancellationToken)
        {
            var query = _repo.GetAllQueryable();
            var dtoQuery = query.ProjectTo<LabTestDto>(_mapper.ConfigurationProvider);
            var paged = await dtoQuery.ToPagedList(request.PageNumber, request.PageSize);
            if (paged.Items.Count == 0)
            {
                return Result<PagedList<LabTestDto>>.EmptyResult(nameof(LabTestDto));
            }
            return Result<PagedList<LabTestDto>>.SuccessResult(paged);
        }
    }
}
