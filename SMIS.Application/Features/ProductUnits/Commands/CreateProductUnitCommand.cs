using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands
{
    public record CreateProductUnitCommand(ProductUnitCreateDto ProductUnitCreateDto) : IRequest<Result<ProductUnitDto>>;

    internal sealed class CreateProductUnitCommandHandler : IRequestHandler<CreateProductUnitCommand, Result<ProductUnitDto>>
    {
        private readonly IProductUnitRepository _productUnitRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductUnitCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductUnitRepository productUnitRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productUnitRepository = productUnitRepository;
        }

        public async Task<Result<ProductUnitDto>> Handle(CreateProductUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ProductUnit>(request.ProductUnitCreateDto);
            await _productUnitRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ProductUnitDto>.SuccessResult(_mapper.Map<ProductUnitDto>(entity));
        }
    }
}