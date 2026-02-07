using Bogus;
using SMIS.Application.DTO.ProductPrices;

namespace SMIS.Test.Utilities;

public class ProductPriceFixtureBuilder
{
    private readonly Faker<ProductPriceCreateDto> _faker;
    private string? _productId;
    private string? _productUnitId;

    public ProductPriceFixtureBuilder()
    {
        _faker = new Faker<ProductPriceCreateDto>()
            .RuleFor(p => p.BuyPrice, f => f.Random.Long(100, 40000))
            .RuleFor(p => p.SellPrice, f => f.Random.Long(150, 50000))
            .RuleFor(p => p.EffectiveDate, f => f.Date.Past(1))
            .RuleFor(p => p.EndDate, f => f.Random.Bool() ? f.Date.Future(1) : null)
            .RuleFor(p => p.IsActive, true);
    }

    public ProductPriceFixtureBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    public ProductPriceFixtureBuilder WithProductUnitId(string productUnitId)
    {
        _productUnitId = productUnitId;
        return this;
    }

    public ProductPriceFixtureBuilder WithDependencies(string productId, string productUnitId)
    {
        _productId = productId;
        _productUnitId = productUnitId;
        return this;
    }

    public ProductPriceFixtureBuilder WithBuyPrice(long buyPrice)
    {
        _faker.RuleFor(p => p.BuyPrice, buyPrice);
        return this;
    }

    public ProductPriceFixtureBuilder WithSellPrice(long sellPrice)
    {
        _faker.RuleFor(p => p.SellPrice, sellPrice);
        return this;
    }

    public ProductPriceFixtureBuilder WithEffectiveDate(DateTime effectiveDate)
    {
        _faker.RuleFor(p => p.EffectiveDate, effectiveDate);
        return this;
    }

    public ProductPriceFixtureBuilder WithEndDate(DateTime? endDate)
    {
        _faker.RuleFor(p => p.EndDate, endDate);
        return this;
    }

    public ProductPriceFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(p => p.IsActive, isActive);
        return this;
    }

    public ProductPriceCreateDto Build()
    {
        var productPrice = _faker.Generate();
        productPrice.ProductId = _productId ?? throw new InvalidOperationException("ProductId is required");
        productPrice.ProductUnitId = _productUnitId ?? throw new InvalidOperationException("ProductUnitId is required");
        return productPrice;
    }
}
