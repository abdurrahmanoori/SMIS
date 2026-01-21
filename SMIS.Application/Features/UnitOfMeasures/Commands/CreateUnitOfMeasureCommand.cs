using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record CreateUnitOfMeasureCommand(UnitOfMeasureCreateDto UnitOfMeasureCreateDto) : IRequest<Result<UnitOfMeasureCreateDto>>;

    internal sealed class CreateUnitOfMeasureCommandHandler : IRequestHandler<CreateUnitOfMeasureCommand, Result<UnitOfMeasureCreateDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUnitOfMeasureCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUnitOfMeasureRepository unitOfMeasureRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<UnitOfMeasureCreateDto>> Handle(CreateUnitOfMeasureCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UnitOfMeasure>(request.UnitOfMeasureCreateDto);
            
            await _unitOfMeasureRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<UnitOfMeasureCreateDto>.SuccessResult(request.UnitOfMeasureCreateDto);
        }
    }
}
