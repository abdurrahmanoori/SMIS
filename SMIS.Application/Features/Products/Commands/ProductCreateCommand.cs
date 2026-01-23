using AutoMapper;
using MediatR;
using SMIS.Application.DTO.Common.Response;
using SMIS.Application.DTO.Products;
using SMIS.Application.Extensions;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Localization;
using SMIS.Application.Repositories.Products;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Products.Commands
{
    public record ProductCreateCommand(ProductCreateDto ProductCreateDto) : IRequest<Result<ProductDto>>;

    internal sealed class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Result<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly ITranslationKeyRepository _translationKeyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository, ITranslationKeyRepository translationKeyRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
            _translationKeyRepository = translationKeyRepository;
        }

        public async Task<Result<ProductDto>> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
        {
            await _translationKeyRepository.AddTranslationKeysForEntity(request.ProductCreateDto, _unitOfWork);

            var entity = _mapper.Map<Product>(request.ProductCreateDto);
            await _productRepository.AddAsync(entity);
            await _unitOfWork.SaveChanges(cancellationToken);

            return Result<ProductDto>.SuccessResult(_mapper.Map<ProductDto>(entity));
        }
    }
}