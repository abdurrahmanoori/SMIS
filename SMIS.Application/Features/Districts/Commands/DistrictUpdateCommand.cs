using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictUpdateCommand(string Id, DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictUpdateCommandHandler : IRequestHandler<DistrictUpdateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DistrictUpdateCommandHandler(
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
            DistrictUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<DistrictDto>.NotFoundResult(nameof(DistrictDto.Id));
            }

            _mapper.Map(request.DistrictCreateDto, entity);

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<DistrictDto>(entity);
            return Result<DistrictDto>.SuccessResult(dto);
        }
    }
}