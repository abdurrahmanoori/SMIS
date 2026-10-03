using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Application.Services;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictUpdateCommand(string Id, DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictUpdateCommandHandler : IRequestHandler<DistrictUpdateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationDbContext _context;

        public DistrictUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IDistrictRepository districtRepository,
            IApplicationDbContext context
        )
        {
            _unitOfWork = unitOfWork;
            _districtRepository = districtRepository;
            _context = context;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictUpdateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = await _districtRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<DistrictDto>.NotFound(nameof(DistrictDto.Id));
            }

            var province = await _context.Provinces
                .SingleOrDefaultAsync(
                    item => item.Id == request.DistrictCreateDto.ProvinceId,
                    cancellationToken);

            if (province == null)
            {
                return Result<DistrictDto>.Validation(
                    "district.province_not_found",
                    "The selected province does not exist.",
                    nameof(DistrictCreateDto.ProvinceId));
            }

            request.DistrictCreateDto.ApplyTo(entity);
            entity.Province = province;

            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = entity.ToDto();
            return Result<DistrictDto>.Success(dto);
        }
    }
}