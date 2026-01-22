using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceCreateCommand(ProvinceCreateDto ProvinceCreateDto) : IRequest<Result<ProvinceCreateDto>>;

    internal sealed class ProvinceCreateCommandHandler : IRequestHandler<ProvinceCreateCommand, Result<ProvinceCreateDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProvinceCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProvinceRepository provinceRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _provinceRepository = provinceRepository;
        }

        public async Task<Result<ProvinceCreateDto>> Handle(ProvinceCreateCommand request,
            CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Province>(request.ProvinceCreateDto);

            // Ensure at least one translation exists for Name fallback
            if ((entity.Translations == null || entity.Translations.Count == 0) && !string.IsNullOrWhiteSpace(request.ProvinceCreateDto.Name))
            {
                entity.Translations = new List<ProvinceTranslation>
                {
                    new ProvinceTranslation { LanguageCode = "en", LanguageId = "1", IsDefault = true, Name = request.ProvinceCreateDto.Name }
                };
            }

            await _provinceRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<ProvinceCreateDto>.SuccessResult(request.ProvinceCreateDto);
        }
    }
}
