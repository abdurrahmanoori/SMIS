using Bogus;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Infrastructure.Mobile.Test.Utilities;

/// <summary>
/// Fluent builder for Shop domain entities using Bogus.
/// Mirrors ShopFixtureBuilder in SMIS.Test -- same conventions, domain layer target.
/// </summary>
public class ShopEntityBuilder
{
    private string? _name;
    private ShopType _shopType = ShopType.RetailShop;
    private string? _address;
    private string? _phoneNumber;
    private string? _email;
    private string? _taxNumber;
    private bool _isActive = true;
    private bool _isSynced = false;
    private DateTime _lastModifiedUtc = DateTime.UtcNow;

    private static readonly Faker Faker = new();

    public ShopEntityBuilder WithName(string name) { _name = name; return this; }
    public ShopEntityBuilder WithShopType(ShopType shopType) { _shopType = shopType; return this; }
    public ShopEntityBuilder WithAddress(string? address) { _address = address; return this; }
    public ShopEntityBuilder WithPhoneNumber(string? phoneNumber) { _phoneNumber = phoneNumber; return this; }
    public ShopEntityBuilder WithEmail(string? email) { _email = email; return this; }
    public ShopEntityBuilder WithTaxNumber(string? taxNumber) { _taxNumber = taxNumber; return this; }
    public ShopEntityBuilder WithIsActive(bool isActive) { _isActive = isActive; return this; }
    public ShopEntityBuilder AsSynced() { _isSynced = true; return this; }
    public ShopEntityBuilder WithLastModifiedUtc(DateTime utc) { _lastModifiedUtc = utc; return this; }

    public Shop Build()
    {
        var name = _name ?? Faker.Company.CompanyName();
        var shop = Shop.Create(name, _shopType, _address, _phoneNumber, _email, _taxNumber, _isActive);
        shop.IsSyncedToServer = _isSynced;
        shop.LastModifiedUtc = _lastModifiedUtc;
        return shop;
    }

    public List<Shop> BuildMany(int count)
        => Enumerable.Range(0, count).Select(_ => new ShopEntityBuilder()
            .WithShopType(_shopType)
            .WithIsActive(_isActive)
            .Build()).ToList();
}
