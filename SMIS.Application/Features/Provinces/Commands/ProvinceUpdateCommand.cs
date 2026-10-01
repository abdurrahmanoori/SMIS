using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Provinces;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceUpdateCommand(string Id, ProvinceCreateDto ProvinceDto) : IRequest<Result<ProvinceDto>>;

    internal sealed class ProvinceUpdateCommandHandler : IRequestHandler<ProvinceUpdateCommand, Result<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceUpdateCommandHandler(
            IUnitOfWork unitOfWork,
            IProvinceRepository provinceRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceRepository = provinceRepository;
        }

        public async Task<Result<ProvinceDto>> Handle(
            ProvinceUpdateCommand request,
            CancellationToken cancellationToken)
        {
            var existing = await _provinceRepository.GetFirstOrDefaultAsync(
                x => x.Id == request.Id,
                includeProperties: nameof(Province.Translations));
            if (existing is null) return Result<ProvinceDto>.NotFound(request.Id);

            ProvinceMapping.Apply(existing, request.ProvinceDto);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<ProvinceDto>.Success(ProvinceMapping.ToDto(existing));
        }
    }
}
