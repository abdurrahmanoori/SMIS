using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Laboratory;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Laboratory;

namespace SMIS.Application.Features.Laboratory.LabTests.Commands
{
    public record UpdateLabTestCommand(int Id, LabTestCreateDto LabTestDto) : IRequest<Result<LabTestDto>>;

    internal sealed class UpdateLabTestCommandHandler : IRequestHandler<UpdateLabTestCommand, Result<LabTestDto>>
    {
        private readonly ILabTestRepository _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateLabTestCommandHandler(IUnitOfWork unitOfWork, ILabTestRepository repo, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Result<LabTestDto>> Handle(UpdateLabTestCommand request, CancellationToken cancellationToken)
        {
            var existing = await _repo.GetByIdAsync(request.Id);
            if (existing is null)
            {
                return Result<LabTestDto>.NotFoundResult(request.Id);
            }

            _mapper.Map(request.LabTestDto, existing);
            await _unitOfWork.SaveChanges(cancellationToken);

            var response = _mapper.Map<LabTestDto>(existing);
            return Result<LabTestDto>.SuccessResult(response);
        }
    }
}
