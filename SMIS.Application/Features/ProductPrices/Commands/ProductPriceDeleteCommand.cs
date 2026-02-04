using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.ProductPrices;

namespace SMIS.Application.Features.ProductPrices.Commands;

public record ProductPriceDeleteCommand(string Id) : IRequest<Result<Unit>>;

internal sealed class ProductPriceDeleteCommandHandler : IRequestHandler<ProductPriceDeleteCommand, Result<Unit>>
{
    private readonly IProductPriceRepository _productPriceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProductPriceDeleteCommandHandler(IUnitOfWork unitOfWork, IProductPriceRepository productPriceRepository)
    {
        _unitOfWork = unitOfWork;
        _productPriceRepository = productPriceRepository;
    }

    public async Task<Result<Unit>> Handle(ProductPriceDeleteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _productPriceRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            return Result<Unit>.NotFoundResult(request?.Id);
        }

        await _productPriceRepository.RemoveAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<Unit>.SuccessResult(Unit.Value);
    }
}
