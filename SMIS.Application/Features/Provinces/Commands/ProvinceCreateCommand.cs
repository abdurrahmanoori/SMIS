using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;
using SMIS.Application.Mappings;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceCreateCommand(ProvinceCreateDto ProvinceCreateDto) : IRequest<Result<ProvinceDto>>;

    internal sealed class ProvinceCreateCommandHandler : IRequestHandler<ProvinceCreateCommand, Result<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IProvinceRepository provinceRepository
        )
        {
            _unitOfWork = unitOfWork;
            _provinceRepository = provinceRepository;
        }

        public async Task<Result<ProvinceDto>> Handle(
            ProvinceCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var entity = request.ProvinceCreateDto.ToEntity();

            // Ensure at least one translation exists for Name fallback
            if ((entity.Translations == null || entity.Translations.Count == 0) &&
                !string.IsNullOrWhiteSpace(request.ProvinceCreateDto.Name))
            {
                entity.Translations = new List<ProvinceTranslation>
                {
                    new ProvinceTranslation
                    {
                        LanguageCode = "en", LanguageId = "1", IsDefault = true, Name = request.ProvinceCreateDto.Name
                    }
                };
            }

            await _provinceRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<ProvinceDto>.Success(entity.ToDto());
        }
    }
}