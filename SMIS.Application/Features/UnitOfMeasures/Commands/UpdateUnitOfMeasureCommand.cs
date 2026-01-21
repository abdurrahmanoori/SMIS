using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UpdateUnitOfMeasureCommand(string PublicId, UnitOfMeasureCreateDto UnitOfMeasureCreateDto) : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class UpdateUnitOfMeasureCommandHandler : IRequestHandler<UpdateUnitOfMeasureCommand, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUnitOfMeasureCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<UnitOfMeasureDto>> Handle(UpdateUnitOfMeasureCommand request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfMeasureRepository.GetByIdAsync(request.PublicId);
            if (entity == null)
            {
                return Result<UnitOfMeasureDto>.NotFoundResult(nameof(UnitOfMeasureDto.PublicId));
            }

            _mapper.Map(request.UnitOfMeasureCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<UnitOfMeasureDto>(entity);
            return Result<UnitOfMeasureDto>.SuccessResult(dto);
        }
    }
}
