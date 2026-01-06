using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Laboratory;
using SMIS.Application.Repositories.Laboratory;

namespace SMIS.Application.Features.Laboratory.LabTests.Queries
{
    public record GetLabTestByIdQuery(int Id) : IRequest<Result<LabTestDto>>;

    internal sealed class GetLabTestByIdQueryHandler : IRequestHandler<GetLabTestByIdQuery, Result<LabTestDto>>
    {
        private readonly ILabTestRepository _repo;
        private readonly IMapper _mapper;

        public GetLabTestByIdQueryHandler(ILabTestRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Result<LabTestDto>> Handle(GetLabTestByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByIdAsync(request.Id);
            if (entity is null)
            {
                return Result<LabTestDto>.NotFoundResult(request.Id);
            }

            var dto = _mapper.Map<LabTestDto>(entity);
            return Result<LabTestDto>.SuccessResult(dto);
        }
    }
}
