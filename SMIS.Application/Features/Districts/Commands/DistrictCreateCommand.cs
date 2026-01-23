using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Districts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Districts;
using SMIS.Application.Repositories.Localization;
using SMIS.Domain.Entities.Localization;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Districts.Commands
{
    public record DistrictCreateCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictDto>>;

    internal sealed class DistrictCreateCommandHandler : IRequestHandler<DistrictCreateCommand, Result<DistrictDto>>
    {

        private readonly IDistrictRepository _districtRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DistrictCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IDistrictRepository districtRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<DistrictDto>> Handle(DistrictCreateCommand request,
            CancellationToken cancellationToken)
        {
            var translationKey = new TranslationKey
            {
                Name = request.DistrictCreateDto.Name,
                IsActive = true
            };
            var entity = _mapper.Map<District>(request.DistrictCreateDto);
            entity.TranslationKey = translationKey;

            await _districtRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<DistrictDto>.SuccessResult(_mapper.Map<DistrictDto>(entity));
        }
    }
}