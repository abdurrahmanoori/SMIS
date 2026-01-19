using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record UpdateDistrictCommand(string PublicId, DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class UpdateDistrictCommandHandler : IRequestHandler<UpdateDistrictCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateDistrictCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IDistrictRepository districtRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(UpdateDistrictCommand request, CancellationToken cancellationToken)
        {
            var entity = await _districtRepository.GetByIdAsync(request.PublicId);
            if (entity == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto.PublicId));
            }

            _mapper.Map(request.DistrictCreateDto, entity);
            await _districtRepository.UpdateAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<DistrictDto>(entity);
            return Result<DistrictDto>.SuccessResult(dto);
        }
    }
}