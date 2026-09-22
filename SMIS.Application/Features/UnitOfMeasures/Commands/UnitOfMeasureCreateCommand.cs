using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.UnitOfMeasures;
using SMIS.Application.Services;

namespace SMIS.Application.Features.UnitOfMeasures.Commands
{
    public record UnitOfMeasureCreateCommand(UnitOfMeasureCreateDto UnitOfMeasureCreateDto)
        : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class
        UnitOfMeasureCreateCommandHandler : IRequestHandler<UnitOfMeasureCreateCommand, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IApplicationDbContext _db;
        private readonly IMapper _mapper;

        public UnitOfMeasureCreateCommandHandler(
            IApplicationDbContext db,
            IMapper mapper,
            IUnitOfMeasureRepository unitOfMeasureRepository
        )
        {
            _db = db;
            _mapper = mapper;
            _unitOfMeasureRepository = unitOfMeasureRepository;
        }

        public async Task<Result<UnitOfMeasureDto>> Handle(
            UnitOfMeasureCreateCommand request,
            CancellationToken cancellationToken
        )
        {
            var dto = request.UnitOfMeasureCreateDto;
            var entity = UnitOfMeasureCommandRules.Create(
                dto.Name,
                dto.Symbol,
                dto.Description);

            await _unitOfMeasureRepository.AddAsync(entity);
            await _db.SaveChangesAsync(cancellationToken);

            return Result<UnitOfMeasureDto>.SuccessResult(_mapper.Map<UnitOfMeasureDto>(entity));
        }
    }
}