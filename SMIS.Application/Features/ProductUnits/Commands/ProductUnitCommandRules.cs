using SMIS.Application.Common.Response;
using SMIS.Application.DTO.ProductUnits;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.ProductUnits.Commands;

/// <summary>
/// Product-unit business rules shared by normal online commands and offline sync commands.
/// </summary>
internal static class ProductUnitCommandRules
{
    public static async Task<Result<ProductUnitDto>?> ValidateCreateAsync(
        Product product,
        string productId,
        string unitOfMeasureId,
        decimal baseUnitQuantity,
        IProductUnitRepository repository,
        CancellationToken cancellationToken
    )
    {
        if (IsInvalidBaseQuantity(product, unitOfMeasureId, baseUnitQuantity))
            return BaseUnitMustEqualOne();

        if (await repository.ExistsPairAsync(
                productId,
                unitOfMeasureId,
                cancellationToken: cancellationToken))
            return DuplicatePair();

        return null;
    }

    public static async Task<Result<ProductUnitDto>?> ValidateMutationAsync(
        ProductUnit value,
        Product currentProduct,
        Product targetProduct,
        string productId,
        string unitOfMeasureId,
        decimal baseUnitQuantity,
        IProductUnitRepository repository,
        CancellationToken cancellationToken
    )
    {
        var changed =
            !string.Equals(value.ProductId, productId, StringComparison.Ordinal) ||
            !string.Equals(value.UnitOfMeasureId, unitOfMeasureId, StringComparison.Ordinal) ||
            value.BaseUnitQuantity != baseUnitQuantity;

        if (string.Equals(currentProduct.BaseUnitId, value.UnitOfMeasureId, StringComparison.Ordinal) && changed)
            return BaseUnitProtected();

        if (changed && await repository.HasUsageAsync(value.Id, cancellationToken))
            return ConversionInUse();

        if (IsInvalidBaseQuantity(targetProduct, unitOfMeasureId, baseUnitQuantity))
            return BaseUnitMustEqualOne();

        if (await repository.ExistsPairAsync(
                productId,
                unitOfMeasureId,
                value.Id,
                cancellationToken))
            return DuplicatePair();

        return null;
    }

    public static void Apply(
        ProductUnit value,
        string productId,
        string unitOfMeasureId,
        decimal baseUnitQuantity
    )
    {
        value.SetProductId(productId);
        value.SetUnitOfMeasureId(unitOfMeasureId);
        value.SetBaseUnitQuantity(baseUnitQuantity);
    }

    public static bool IsInvalidBaseQuantity(
        Product product,
        string unitOfMeasureId,
        decimal baseUnitQuantity
    ) =>
        string.Equals(product.BaseUnitId, unitOfMeasureId, StringComparison.Ordinal) &&
        baseUnitQuantity != 1m;

    public static Result<ProductUnitDto> DuplicatePair() =>
        Result<ProductUnitDto>.FailureResult(
            "ProductUnitAlreadyExists",
            "This unit of measurement is already configured for the selected product.");

    public static Result<ProductUnitDto> BaseUnitProtected() =>
        Result<ProductUnitDto>.FailureResult(
            "BaseProductUnitProtected",
            "The product's base-unit mapping is managed by the product and cannot be changed or deleted directly.");

    public static Result<ProductUnitDto> BaseUnitMustEqualOne() =>
        Result<ProductUnitDto>.FailureResult(
            "InvalidBaseUnitQuantity",
            "The product's base unit must have BaseUnitQuantity = 1.");

    public static Result<ProductUnitDto> ConversionInUse() =>
        Result<ProductUnitDto>.FailureResult(
            "ProductUnitInUse",
            "This product-unit conversion has pricing or inventory history and cannot be changed or deleted.");
}