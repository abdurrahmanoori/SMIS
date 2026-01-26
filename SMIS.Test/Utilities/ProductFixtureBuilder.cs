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
    private bool _categoryIdSet;
    private bool _nameSet;
    private bool _descriptionSet;
    private bool _skuSet;
    private bool _barcodeSet;
    private bool _imageUrlSet;

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

    public ProductFixtureBuilder WithCategoryId(string? categoryId)
    {
        _categoryId = categoryId;
        _categoryIdSet = true;
        return this;
    }

    public ProductFixtureBuilder WithDependencies(string shopId, string unitId, string? categoryId)
    {
        _shopId = shopId;
        _unitId = unitId;
        _categoryId = categoryId;
        _categoryIdSet = true;
        return this;
    }

    public ProductFixtureBuilder WithName(string name)
    {
        _name = name;
        _nameSet = true;
        return this;
    }

    public ProductFixtureBuilder WithDescription(string? description)
    {
        _description = description;
        _descriptionSet = true;
        return this;
    }

    public ProductFixtureBuilder WithSKU(string sku)
    {
        _sku = sku;
        _skuSet = true;
        return this;
    }

    public ProductFixtureBuilder WithBarcode(string? barcode)
    {
        _barcode = barcode;
        _barcodeSet = true;
        return this;
    }

    public ProductFixtureBuilder WithImageUrl(string? imageUrl)
    {
        _imageUrl = imageUrl;
        _imageUrlSet = true;
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

    public ProductCreateDto Build() => new()
    {
        ShopId = _shopId ?? _fixture.Create<string>(),
        BaseUnitId = _unitId ?? _fixture.Create<string>(),
        CategoryId = _categoryIdSet ? _categoryId : _categoryId,
        Name = _nameSet ? _name! : GenerateUniqueName(),
        Description = _descriptionSet ? _description : GenerateUniqueDescription(),
        SKU = _skuSet ? _sku! : GenerateUniqueSKU(),
        Barcode = _barcodeSet ? _barcode : null,
        ImageUrl = _imageUrlSet ? _imageUrl : null,
        SalePricePerBaseUnit = _price ?? GenerateRandomPrice(),
        IsActive = _isActive ?? true
    };

    private static string GenerateUniqueName() => $"Name{Guid.NewGuid()}";
    private static string GenerateUniqueDescription() => $"Description{Guid.NewGuid()}";
    private static string GenerateUniqueSKU() => $"SKU{Guid.NewGuid()}";
    private int GenerateRandomPrice() => Math.Abs(_fixture.Create<int>()) % 100000;
}