using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Application.Services;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictCreateCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictCreateCommandHandler : IRequestHandler<DistrictCreateCommand, Result<DistrictDto>>
    {
        private readonly IDistrictRepository _districtRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public DistrictCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IDistrictRepository districtRepository,
            IApplicationDbContext context
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
            _context = context;
        }

        public async Task<Result<DistrictDto>> Handle(
            DistrictCreateCommand request,
            CancellationToken cancellationToken
        )
        {
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

            var entity = _mapper.Map<District>(request.DistrictCreateDto);
            entity.Province = province;

            await _districtRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictDto>.Success(_mapper.Map<DistrictDto>(entity));
        }
    }
}