using Bogus;
using SMIS.Application.DTO.Products;

namespace SMIS.Test.Utilities;

public class ProductFixtureBuilder
{
    private readonly Faker<ProductCreateDto> _faker;
    private string? _shopId;
    private string? _unitId;
    private string? _categoryId;

    public ProductFixtureBuilder()
    {
        _faker = new Faker<ProductCreateDto>()
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.SKU, f => f.Commerce.Ean13())
            .RuleFor(p => p.Barcode, f => f.Random.Bool() ? f.Random.Replace("########") : null)
            .RuleFor(p => p.ImageUrl, f => f.Random.Bool() ? f.Image.PicsumUrl() : null)
            .RuleFor(p => p.SalePricePerBaseUnit, f => f.Random.Int(100, 50000))
            .RuleFor(p => p.IsActive, true);
    }

    public ProductFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public ProductFixtureBuilder WithUnitId(string unitId)
    {
        _unitId = unitId;
        return this;
    }

    public ProductFixtureBuilder WithCategoryId(string? categoryId)
    {
        _categoryId = categoryId;
        return this;
    }

    public ProductFixtureBuilder WithDependencies(string shopId, string unitId, string? categoryId)
    {
        _shopId = shopId;
        _unitId = unitId;
        _categoryId = categoryId;
        return this;
    }

    public ProductFixtureBuilder WithName(string name)
    {
        _faker.RuleFor(p => p.Name, name);
        return this;
    }

    public ProductFixtureBuilder WithDescription(string? description)
    {
        _faker.RuleFor(p => p.Description, description);
        return this;
    }

    public ProductFixtureBuilder WithSKU(string sku)
    {
        _faker.RuleFor(p => p.SKU, sku);
        return this;
    }

    public ProductFixtureBuilder WithBarcode(string? barcode)
    {
        _faker.RuleFor(p => p.Barcode, barcode);
        return this;
    }

    public ProductFixtureBuilder WithImageUrl(string? imageUrl)
    {
        _faker.RuleFor(p => p.ImageUrl, imageUrl);
        return this;
    }

    public ProductFixtureBuilder WithSalePricePerBaseUnit(int price)
    {
        _faker.RuleFor(p => p.SalePricePerBaseUnit, price);
        return this;
    }

    public ProductFixtureBuilder WithPrice(int price)
    {
        _faker.RuleFor(p => p.SalePricePerBaseUnit, price);
        return this;
    }

    public ProductFixtureBuilder WithIsActive(bool isActive)
    {
        _faker.RuleFor(p => p.IsActive, isActive);
        return this;
    }

    public ProductCreateDto Build()
    {
        var product = _faker.Generate();
        product.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        product.BaseUnitId = _unitId ?? throw new InvalidOperationException("BaseUnitId is required");
        product.CategoryId = _categoryId;
        return product;
    }
}