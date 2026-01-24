using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Common;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.UnitOfMeasures;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.UnitOfMeasures.Queries
{
    public record UnitOfMeasureGetListQuery(int PageNumber = 1, int PageSize = 25) : IRequest<Result<PagedList<UnitOfMeasureDto>>>;

    internal sealed class UnitOfMeasureGetListQueryHandler : IRequestHandler<UnitOfMeasureGetListQuery, Result<PagedList<UnitOfMeasureDto>>>
    {
        private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
        private readonly IMapper _mapper;

        public UnitOfMeasureGetListQueryHandler(IUnitOfMeasureRepository unitOfMeasureRepository, IMapper mapper)
        {
            _unitOfMeasureRepository = unitOfMeasureRepository;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<UnitOfMeasureDto>>> Handle(UnitOfMeasureGetListQuery request, CancellationToken cancellationToken)
        {
            var unitOfMeasures = await _unitOfMeasureRepository.GetAllQueryable()
                .ToPagedList(request.PageNumber, request.PageSize);

            if (!unitOfMeasures.Items.Any())
            {
                return Result<PagedList<UnitOfMeasureDto>>.EmptyResult(nameof(UnitOfMeasureDto));
            }

            var unitOfMeasureDtos = _mapper.Map<List<UnitOfMeasureDto>>(unitOfMeasures.Items);

            return Result<PagedList<UnitOfMeasureDto>>.SuccessResult(new PagedList<UnitOfMeasureDto>
            {
                Items = unitOfMeasureDtos,
                TotalCount = unitOfMeasures.TotalCount,
                PageNumber = unitOfMeasures.PageNumber,
                PageSize = unitOfMeasures.PageSize,
                TotalPages = unitOfMeasures.TotalPages
            });
        }
    }
}
