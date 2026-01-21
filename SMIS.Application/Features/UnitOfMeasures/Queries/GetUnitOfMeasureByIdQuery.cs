using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Queries
{
    public record GetUnitOfMeasureByIdQuery(string PublicId) : IRequest<Result<UnitOfMeasureDto>>;

    internal sealed class GetUnitOfMeasureByIdQueryHandler : IRequestHandler<GetUnitOfMeasureByIdQuery, Result<UnitOfMeasureDto>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IMapper _mapper;

        public GetUnitOfMeasureByIdQueryHandler(IUnitOfMeasureRepository unitOfMeasureRepository, IMapper mapper)
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _mapper = mapper;
        }

        public async Task<Result<UnitOfMeasureDto>> Handle(GetUnitOfMeasureByIdQuery request, CancellationToken cancellationToken)
        {
            var dbUnitOfMeasure = await _unitOfMeasureRepository.GetFirstOrDefaultAsync(x => x.PublicId == request.PublicId);
            
            if (dbUnitOfMeasure == null)
            {
                return Result<UnitOfMeasureDto>.NotFoundResult(nameof(UnitOfMeasureDto));
            }

            var unitOfMeasure = _mapper.Map<UnitOfMeasureDto>(dbUnitOfMeasure);

            return Result<UnitOfMeasureDto>.SuccessResult(unitOfMeasure);
        }
    }
}
