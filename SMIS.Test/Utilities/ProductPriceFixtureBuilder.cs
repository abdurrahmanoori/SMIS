using Bogus;
using SMIS.Application.DTO.ProductPrices;

namespace SMIS.Test.Utilities;

public class ProductPriceFixtureBuilder
{
    private readonly Faker<ProductPriceCreateDto> _faker;
    private string? _productId;

    public ProductPriceFixtureBuilder()
    {
        _faker = new Faker<ProductPriceCreateDto>()
            .RuleFor(p => p.Price, f => f.Random.Int(100, 50000))
            .RuleFor(p => p.EffectiveDate, f => f.Date.Past(1))
            .RuleFor(p => p.EndDate, f => f.Random.Bool() ? f.Date.Future(1) : null)
            .RuleFor(p => p.IsActive, true);
    }

    public ProductPriceFixtureBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    public ProductPriceFixtureBuilder WithDependencies(string productId)
    {
        _productId = productId;
        return this;
    }

    public ProductPriceFixtureBuilder WithPrice(int price)
    {
        _faker.RuleFor(p => p.Price, price);
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
        return productPrice;
    }
}
