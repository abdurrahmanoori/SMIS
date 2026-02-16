using Bogus;
using SMIS.Application.DTO.LoanAccounts;

namespace SMIS.Test.Utilities;

public class LoanAccountFixtureBuilder
{
    private readonly Faker<LoanAccountCreateDto> _faker;
    private string? _shopId;
    private string? _customerId;
    private string? _productId;
    private string? _unitId;

    public LoanAccountFixtureBuilder()
    {
        _faker = new Faker<LoanAccountCreateDto>()
            .RuleFor(l => l.Quantity, f => f.Random.Decimal(1, 100))
            .RuleFor(l => l.PriceAtLoanTime, f => f.Random.Decimal(100, 10000))
            .RuleFor(l => l.TotalAmount, f => f.Random.Long(1000, 100000))
            .RuleFor(l => l.DueDate, f => f.Random.Bool() ? f.Date.Future() : null)
            .RuleFor(l => l.Notes, f => f.Random.Bool() ? f.Lorem.Sentence() : null);
    }

    public LoanAccountFixtureBuilder WithShopId(string shopId)
    {
        _shopId = shopId;
        return this;
    }

    public LoanAccountFixtureBuilder WithCustomerId(string customerId)
    {
        _customerId = customerId;
        return this;
    }

    public LoanAccountFixtureBuilder WithProductId(string productId)
    {
        _productId = productId;
        return this;
    }

    public LoanAccountFixtureBuilder WithUnitId(string unitId)
    {
        _unitId = unitId;
        return this;
    }

    public LoanAccountFixtureBuilder WithDependencies(string shopId, string customerId, string productId, string unitId)
    {
        _shopId = shopId;
        _customerId = customerId;
        _productId = productId;
        _unitId = unitId;
        return this;
    }

    public LoanAccountFixtureBuilder WithQuantity(decimal quantity)
    {
        _faker.RuleFor(l => l.Quantity, quantity);
        return this;
    }

    public LoanAccountFixtureBuilder WithPriceAtLoanTime(decimal priceAtLoanTime)
    {
        _faker.RuleFor(l => l.PriceAtLoanTime, priceAtLoanTime);
        return this;
    }

    public LoanAccountFixtureBuilder WithTotalAmount(long totalAmount)
    {
        _faker.RuleFor(l => l.TotalAmount, totalAmount);
        return this;
    }

    public LoanAccountFixtureBuilder WithDueDate(DateTime? dueDate)
    {
        _faker.RuleFor(l => l.DueDate, dueDate);
        return this;
    }

    public LoanAccountFixtureBuilder WithNotes(string? notes)
    {
        _faker.RuleFor(l => l.Notes, notes);
        return this;
    }

    public LoanAccountCreateDto Build()
    {
        var loanAccount = _faker.Generate();
        loanAccount.ShopId = _shopId ?? throw new InvalidOperationException("ShopId is required");
        loanAccount.CustomerId = _customerId ?? throw new InvalidOperationException("CustomerId is required");
        loanAccount.ProductId = _productId ?? throw new InvalidOperationException("ProductId is required");
        loanAccount.UnitId = _unitId ?? throw new InvalidOperationException("UnitId is required");
        return loanAccount;
    }
}
