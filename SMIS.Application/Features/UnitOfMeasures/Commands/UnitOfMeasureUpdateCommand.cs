using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UnitOfMeasureUpdateCommand(string Id, UnitOfMeasureCreateDto UnitOfMeasureCreateDto) : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class UnitOfMeasureUpdateCommandHandler : IRequestHandler<UnitOfMeasureUpdateCommand, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UnitOfMeasureUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<UnitOfMeasureDto>> Handle(UnitOfMeasureUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfMeasureRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<UnitOfMeasureDto>.NotFoundResult(nameof(UnitOfMeasureDto.Id));
            }

            // Update existing entity using domain methods
            entity.SetName(request.UnitOfMeasureCreateDto.Name);
            entity.SetSymbol(request.UnitOfMeasureCreateDto.Symbol);
            entity.SetDescription(request.UnitOfMeasureCreateDto.Description);
            entity.SetShopId(request.UnitOfMeasureCreateDto.ShopId);
            
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<UnitOfMeasureDto>(entity);
            return Result<UnitOfMeasureDto>.SuccessResult(dto);
        }
    }
}
