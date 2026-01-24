using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Queries
{
    public record UnitOfMeasureGetByIdQuery(string Id) : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class UnitOfMeasureGetByIdQueryHandler : IRequestHandler<UnitOfMeasureGetByIdQuery, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IMapper _mapper;

        public UnitOfMeasureGetByIdQueryHandler(IUnitOfMeasureRepository unitOfMeasureRepository, IMapper mapper)
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _mapper = mapper;
        }

        public async Task<Result<UnitOfMeasureDto>> Handle(UnitOfMeasureGetByIdQuery request, CancellationToken cancellationToken)
        {
            var dbUnitOfMeasure = await _unitOfMeasureRepository.GetFirstOrDefaultAsync(x => x.Id == request.Id);

            if (dbUnitOfMeasure == null)
            {
                return Result<UnitOfMeasureDto>.NotFoundResult(nameof(UnitOfMeasureDto));
            }

            var unitOfMeasure = _mapper.Map<UnitOfMeasureDto>(dbUnitOfMeasure);

            return Result<UnitOfMeasureDto>.SuccessResult(unitOfMeasure);
        }
    }
}
