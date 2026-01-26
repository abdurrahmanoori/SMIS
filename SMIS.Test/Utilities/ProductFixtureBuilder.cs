using AutoFixture;
using SMIS.Application.DTO.Products;

namespace SMIS.Test.Utilities;

public class ProductFixtureBuilder
{
    private readonly IFixture _fixture;
    private string? _shopId;
    private string? _unitId;
    private string? _categoryId;
    private string? _name;
    private string? _description;
    private string? _sku;
    private string? _barcode;
    private string? _imageUrl;
    private int? _price;
    private bool? _isActive;

    public ProductFixtureBuilder()
    {
        _fixture = new Fixture();
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

    public ProductFixtureBuilder WithCategoryId(string categoryId)
    {
        _categoryId = categoryId;
        return this;
    }

    public ProductFixtureBuilder WithDependencies(string shopId, string unitId, string categoryId)
    {
        _shopId = shopId;
        _unitId = unitId;
        _categoryId = categoryId;
        return this;
    }

    public ProductFixtureBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ProductFixtureBuilder WithDescription(string? description)
    {
        _description = description;
        return this;
    }

    public ProductFixtureBuilder WithSKU(string sku)
    {
        _sku = sku;
        return this;
    }

    public ProductFixtureBuilder WithBarcode(string? barcode)
    {
        _barcode = barcode;
        return this;
    }

    public ProductFixtureBuilder WithImageUrl(string? imageUrl)
    {
        _imageUrl = imageUrl;
        return this;
    }

    public ProductFixtureBuilder WithPrice(int price)
    {
        _price = price;
        return this;
    }

    public ProductFixtureBuilder WithIsActive(bool isActive)
    {
        _isActive = isActive;
        return this;
    }

    public ProductCreateDto Build()
    {
        var product = new ProductCreateDto
        {
            ShopId = _shopId ?? _fixture.Create<string>(),
            BaseUnitId = _unitId ?? _fixture.Create<string>(),
            CategoryId = _categoryId,
            Name = _name ?? $"Name{Guid.NewGuid()}",
            Description = _description ?? $"Description{Guid.NewGuid()}",
            SKU = _sku ?? $"SKU{Guid.NewGuid()}",
            Barcode = _barcode,
            ImageUrl = _imageUrl,
            SalePricePerBaseUnit = _price ?? Math.Abs(_fixture.Create<int>()) % 100000,
            IsActive = _isActive ?? true
        };

        return product;
    }
}
