using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Provinces;
using SMIS.Application.Features.Provinces;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Provinces;

namespace SMIS.Application.Features.Provinces.Commands
{
    public record ProvinceCreateCommand(ProvinceCreateDto ProvinceCreateDto) : IRequest<Result<ProvinceDto>>;

    internal sealed class ProvinceCreateCommandHandler : IRequestHandler<ProvinceCreateCommand, Result<ProvinceDto>>
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceCreateCommandHandler(
            IUnitOfWork unitOfWork,
            IProvinceRepository provinceRepository)
        {
            _unitOfWork = unitOfWork;
            _provinceRepository = provinceRepository;
        }

        public async Task<Result<ProvinceDto>> Handle(
            ProvinceCreateCommand request,
            CancellationToken cancellationToken)
        {
            var entity = ProvinceMapping.Create(request.ProvinceCreateDto);
            await _provinceRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<ProvinceDto>.Success(ProvinceMapping.ToDto(entity));
        }
    }
}
