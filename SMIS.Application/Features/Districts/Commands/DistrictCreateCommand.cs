using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Features.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictCreateCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictCreateCommandHandler : IRequestHandler<DistrictCreateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DistrictCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IDistrictRepository districtRepository)
        {
            _unitOfWork = unitOfWork;
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictCreateCommand request,
            CancellationToken cancellationToken)
        {
            var entity = DistrictMapping.Create(request.DistrictCreateDto);
            await _districtRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictDto>.SuccessResult(DistrictMapping.ToDto(entity));
        }
    }
}
