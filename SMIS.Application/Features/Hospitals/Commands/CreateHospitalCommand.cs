using MediatR;
using AutoMapper;
using SMIS.Application.DTO.Hospitals;
using SMIS.Application.Repositories.Hospitals;
using SMIS.Application.Repositories.Base;
using SMIS.Domain.Entities;
using SMIS.Application.DTO.Common.Response;

namespace SMIS.Application.Features.Hospitals.Commands
{
    public record CreateHospitalCommand(HospitalCreateDto Hospital) : IRequest<Result<HospitalDto>>;

    internal sealed class CreateHospitalCommandHandler : IRequestHandler<CreateHospitalCommand, Result<HospitalDto>>
    {
        private readonly IHospitalRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CreateHospitalCommandHandler(IHospitalRepository repo, IUnitOfWork uow, IMapper mapper)
        {
            _repo = repo; _uow = uow; _mapper = mapper;
        }

        public async Task<Result<HospitalDto>> Handle(CreateHospitalCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Hospital>(request.Hospital);
            await _repo.AddAsync(entity);
            await _uow.SaveChanges(cancellationToken);
            var dto = _mapper.Map<HospitalDto>(entity);
            return Result<HospitalDto>.SuccessResult(dto);
        }
    }
}
