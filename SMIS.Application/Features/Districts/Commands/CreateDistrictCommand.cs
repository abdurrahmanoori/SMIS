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
    public record CreateDistrictCommand(DistrictCreateDto DistrictCreateDto) : IRequest<Result<DistrictCreateDto>>;

    internal sealed class CreateDistrictCommandHandler : IRequestHandler<CreateDistrictCommand, Result<DistrictCreateDto>>
    {

        private readonly IDistrictRepository _districtRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateDistrictCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IDistrictRepository districtRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _districtRepository = districtRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<DistrictCreateDto>> Handle(CreateDistrictCommand request,
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
            return Result<DistrictCreateDto>.SuccessResult(request.DistrictCreateDto);
        }
    }
}