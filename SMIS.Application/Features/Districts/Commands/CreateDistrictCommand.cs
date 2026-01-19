using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Districts.Commands
{
    public record CreateDistrictCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictCreateDto>>;

    internal sealed class CreateDistrictCommandHandler : IRequestHandler<CreateDistrictCommand, Result<DistrictCreateDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateDistrictCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IDistrictRepository districtRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictCreateDto>> Handle(CreateDistrictCommand request,
            CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<District>(request.DistrictCreateDto);

            await _districtRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictCreateDto>.SuccessResult(request.DistrictCreateDto);
        }
    }
}