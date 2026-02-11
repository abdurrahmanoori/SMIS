using Bogus;
using SMIS.Application.DTO.ProductUnits;

namespace SMIS.Test.Utilities;

public class ProductUnitFixtureBuilder
{
    private readonly Faker<ProductUnitCreateDto> _faker;
    private string? _productId;
    private string? _unitOfMeasureId;

    public ProductUnitFixtureBuilder()
    {
        _faker = new Faker<ProductUnitCreateDto>()
            .RuleFor(pu => pu.ConversionFactor,f=> Math.Round(f.Random.Decimal(1,100)));
    }

    public ProductUnitFixtureBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    public ProductUnitFixtureBuilder WithUnitOfMeasureId(string unitOfMeasureId)
    {
        _unitOfMeasureId = unitOfMeasureId;
        return this;
    }

    public ProductUnitFixtureBuilder WithDependencies(string productId, string unitOfMeasureId)
    {
        _productId = productId;
        _unitOfMeasureId = unitOfMeasureId;
        return this;
    }

    public ProductUnitFixtureBuilder WithConversionFactor(decimal conversionFactor)
    {
        _faker.RuleFor(pu => pu.ConversionFactor, conversionFactor);
        return this;
    }

    public ProductUnitCreateDto Build()
    {
        var productUnit = _faker.Generate();
        productUnit.ProductId = _productId ?? throw new InvalidOperationException("ProductId is required");
        productUnit.UnitOfMeasureId = _unitOfMeasureId ?? throw new InvalidOperationException("UnitOfMeasureId is required");
        return productUnit;
    }
}
