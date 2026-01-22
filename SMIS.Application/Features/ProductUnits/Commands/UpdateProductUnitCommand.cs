using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record UpdateProductUnitCommand(string Id, ProductUnitCreateDto ProductUnitCreateDto) : IRequest<Result<ProductUnitDto>>;

    internal sealed class UpdateProductUnitCommandHandler : IRequestHandler<UpdateProductUnitCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductUnitCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(UpdateProductUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = await _productUnitRepository.GetByIdAsync(request.Id);
            if (entity == null)
            {
                return Result<ProductUnitDto>.NotFoundResult(nameof(ProductUnitDto.Id));
            }

            _mapper.Map(request.ProductUnitCreateDto, entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            var dto = _mapper.Map<ProductUnitDto>(entity);
            return Result<ProductUnitDto>.SuccessResult(dto);
        }
    }
}