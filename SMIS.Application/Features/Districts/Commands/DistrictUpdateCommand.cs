using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Features.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictUpdateCommand(string Id, DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictUpdateCommandHandler : IRequestHandler<DistrictUpdateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DistrictUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IDistrictRepository districtRepository)
        {
            _unitOfWork = unitOfWork;
            _districtRepository = districtRepository;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictUpdateCommand request,
            CancellationToken cancellationToken)
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);
            if (entity == null) return Result<DistrictDto>.NotFound(nameof(DistrictDto.Id));

            DistrictMapping.Apply(entity, request.DistrictCreateDto);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictDto>.Success(DistrictMapping.ToDto(entity));
        }
    }
}
