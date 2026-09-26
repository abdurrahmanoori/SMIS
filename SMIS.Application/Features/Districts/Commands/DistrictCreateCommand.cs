using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictCreateCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictCreateCommandHandler : IRequestHandler<DistrictCreateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DistrictCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IDistrictRepository districtRepository
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = _mapper.Map<District>(request.DistrictCreateDto);

            await _districtRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictDto>.SuccessResult(_mapper.Map<DistrictDto>(entity));
        }
    }
}