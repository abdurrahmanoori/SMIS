using AutoFixture;
using SMIS.Application.DTO.Products;

namespace SMIS.Test.Utilities;

public class ProductFixtureBuilder
{
    private readonly IFixture _fixture;
    private string? _shopId;
    private string? _unitId;
    private string? _categoryId;

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

    public ProductCreateDto Build()
    {
        var product = _fixture.Build<ProductCreateDto>()
            .With(p => p.ShopId, _shopId ?? _fixture.Create<string>())
            .With(p => p.BaseUnitId, _unitId ?? _fixture.Create<string>())
            .With(p => p.CategoryId, _categoryId)
            .With(p => p.SalePricePerBaseUnit, Math.Abs(_fixture.Create<int>()) % 100000)
            .With(p => p.IsActive, true)
            .With(p => p.ImageUrl, (string?)null)
            .With(p => p.Barcode, (string?)null)
            .Create();

        return product;
    }
}
