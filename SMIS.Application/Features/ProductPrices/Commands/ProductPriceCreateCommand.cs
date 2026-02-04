using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductPrices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceCreateCommand(ProductPriceCreateDto ProductPriceCreateDto) : IRequest<Result<ProductPriceDto>>;

internal sealed class ProductPriceCreateCommandHandler : IRequestHandler<ProductPriceCreateCommand, Result<ProductPriceDto>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductPriceCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductPriceRepository productPriceRepository, IProductRepository productRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _productPriceRepository = productPriceRepository;
        _productRepository = productRepository;
    }

    public async Task<Result<ProductPriceDto>> Handle(ProductPriceCreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<ProductPrice>(request.ProductPriceCreateDto);

        await _productPriceRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<ProductPriceDto>.SuccessResult(_mapper.Map<ProductPriceDto>(entity));
    }
}
