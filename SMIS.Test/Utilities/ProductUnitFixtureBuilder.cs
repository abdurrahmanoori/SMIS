using Bogus;
using SMIS.Application.DTO.ProductUnits;

namespace SMIS.Test.Utilities;

public class ProductUnitFixtureBuilder
{
    private readonly Faker<ProductUnitCreateDto> _faker;
    private string? _shopId;
    private string? _productId;
    private string? _unitOfMeasureId;

    public ProductUnitFixtureBuilder()
    {
        //_faker = new Faker<ProductUnitCreateDto>()
        //    .RuleFor(pu => pu.ConversionFactor, f => f.Random.Decimal(1, 100));

        _faker = new Faker<ProductUnitCreateDto>()
            .RuleFor(pu => pu.ConversionFactor,f=> Math.Round(f.Random.Decimal(1,100)));


    //    var faker = new AutoFaker<YourModel>()
    //.RuleFor(m => m.DecimalProperty, f => Math.Round(f.Random.Decimal(0, 1000), 2)); // Scale 2

    }

    public ProductUnitFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
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

    public ProductUnitFixtureBuilder WithDependencies(string shopId, string productId, string unitOfMeasureId)
    {
        _shopId = shopId;
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
        productUnit.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        productUnit.ProductId = _productId ?? throw new InvalidOperationException("ProductId is required");
        productUnit.UnitOfMeasureId = _unitOfMeasureId ?? throw new InvalidOperationException("UnitOfMeasureId is required");
        return productUnit;
    }
}
