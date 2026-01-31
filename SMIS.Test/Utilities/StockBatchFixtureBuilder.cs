using Bogus;
using SMIS.Application.DTO.StockBatches;
using SMIS.Domain.Enums;

namespace SMIS.Test.Utilities;

public class StockBatchFixtureBuilder
{
    private readonly Faker<StockBatchCreateDto> _faker;
    private string? _productId;
    private string? _unitId;

    public StockBatchFixtureBuilder()
    {
        _faker = new Faker<StockBatchCreateDto>()
            .RuleFor(sb => sb.BatchNumber, f => f.Random.AlphaNumeric(10))
            .RuleFor(sb => sb.Quantity, f => f.Random.Decimal(1, 1000))
            .RuleFor(sb => sb.ReceivedDate, f => f.Date.Recent(30))
            .RuleFor(sb => sb.ExpirationDate, f => f.Date.Future(1))
            .RuleFor(sb => sb.PurchasePrice, f => f.Random.Long(100, 10000))
            .RuleFor(sb => sb.Status, StatusEnum.Active);
    }

    public StockBatchFixtureBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    public StockBatchFixtureBuilder WithUnitId(string unitId)
    {
        _unitId = unitId;
        return this;
    }

    public StockBatchFixtureBuilder WithDependencies(string productId, string unitId)
    {
        _productId = productId;
        _unitId = unitId;
        return this;
    }

    public StockBatchFixtureBuilder WithBatchNumber(string? batchNumber)
    {
        _faker.RuleFor(sb => sb.BatchNumber, batchNumber);
        return this;
    }

    public StockBatchFixtureBuilder WithQuantity(decimal quantity)
    {
        _faker.RuleFor(sb => sb.Quantity, quantity);
        return this;
    }

    public StockBatchFixtureBuilder WithReceivedDate(DateTime? receivedDate)
    {
        _faker.RuleFor(sb => sb.ReceivedDate, receivedDate);
        return this;
    }

    public StockBatchFixtureBuilder WithExpirationDate(DateTime? expirationDate)
    {
        _faker.RuleFor(sb => sb.ExpirationDate, expirationDate);
        return this;
    }

    public StockBatchFixtureBuilder WithPurchasePrice(long purchasePrice)
    {
        _faker.RuleFor(sb => sb.PurchasePrice, purchasePrice);
        return this;
    }

    public StockBatchFixtureBuilder WithStatus(StatusEnum status)
    {
        _faker.RuleFor(sb => sb.Status, status);
        return this;
    }

    public StockBatchCreateDto Build()
    {
        var stockBatch = _faker.Generate();
        stockBatch.ProductId = _productId ?? throw new InvalidOperationException("ProductId is required");
        stockBatch.UnitId = _unitId ?? throw new InvalidOperationException("UnitId is required");
        return stockBatch;
    }
}
