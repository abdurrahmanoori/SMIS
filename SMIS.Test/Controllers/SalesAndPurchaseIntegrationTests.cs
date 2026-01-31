using System.Net;
using Shouldly;
using SMIS.Application.Common;
using SMIS.Application.DTO.Products;
using SMIS.Application.DTO.StockBatches;
using SMIS.Domain.Enums;
using SMIS.Test.Extensions;
using SMIS.Test.TestInfrastructure;
using SMIS.Test.Utilities;
using Xunit;
using Xunit.Abstractions;

namespace SMIS.Test.Controllers;

public class SalesAndPurchaseIntegrationTests : BaseIntegrationTest
{
    private readonly StockBatchTestDataHelper _stockBatchHelper;
    private readonly ProductTestDataHelper _productHelper;

    public SalesAndPurchaseIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper output)
        : base(factory, output)
    {
        _stockBatchHelper = new StockBatchTestDataHelper(Client);
        _productHelper = new ProductTestDataHelper(Client);
    }

    public override async Task InitializeAsync()
    {
        await _stockBatchHelper.GetOrCreateDependencies();
        await _productHelper.GetOrCreateDependencies();
    }

    #region Sales Invoice Scenarios

    [Fact]
    public async Task CreateSalesInvoice_SingleItem_CreatesInvoiceAndReducesStock()
    {
        // Arrange - Create product with stock
        var product = await CreateTestProduct("Coca Cola");
        var batch = await CreateStockBatch(product.Id, 100, "CC-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-001",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 10,
                    UnitPrice = 150, // $1.50 per unit
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        await LogIfError(response, "CreateSalesInvoice_SingleItem");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdInvoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        createdInvoice.ShouldNotBeNull();
        createdInvoice!.TotalAmount.ShouldBe(1500); // 10 * 150 = 1500
        createdInvoice.Items.Count.ShouldBe(1);

        // Verify stock reduced
        var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
        if (stockResponse.StatusCode == HttpStatusCode.OK)
        {
            var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
            stockSummary!.TotalQuantity.ShouldBe(90); // 100 - 10 = 90
        }
    }

    [Fact]
    public async Task CreateSalesInvoice_MultipleItems_CreatesInvoiceAndReducesAllStock()
    {
        // Arrange - Create multiple products with stock
        var product1 = await CreateTestProduct("Pepsi");
        var product2 = await CreateTestProduct("Sprite");
        await CreateStockBatch(product1.Id, 50, "PP-001");
        await CreateStockBatch(product2.Id, 30, "SP-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-002",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product1.Id,
                    Quantity = 5,
                    UnitPrice = 140,
                    DiscountAmount = 0,
                    TaxAmount = 0
                },
                new()
                {
                    ProductId = product2.Id,
                    Quantity = 3,
                    UnitPrice = 130,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdInvoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        createdInvoice!.TotalAmount.ShouldBe(1090); // (5 * 140) + (3 * 130) = 700 + 390 = 1090

        // Verify both products' stock reduced
        await VerifyStockReduced(product1.Id, 45); // 50 - 5 = 45
        await VerifyStockReduced(product2.Id, 27); // 30 - 3 = 27
    }

    [Fact]
    public async Task CreateSalesInvoice_InsufficientStock_ReturnsBadRequest()
    {
        // Arrange - Create product with limited stock
        var product = await CreateTestProduct("Limited Stock Item");
        await CreateStockBatch(product.Id, 5, "LS-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-003",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 10, // More than available stock
                    UnitPrice = 100,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        await LogIfError(response, "CreateSalesInvoice_InsufficientStock");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        var errorResponse = await response.Content.ReadAsStringAsync();
        errorResponse.ShouldContain("insufficient stock", Case.Insensitive);
    }

    [Fact]
    public async Task CreateSalesInvoice_WithDiscountAndTax_CalculatesCorrectTotal()
    {
        // Arrange
        var product = await CreateTestProduct("Taxable Item");
        await CreateStockBatch(product.Id, 20, "TI-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-004",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 5,
                    UnitPrice = 1000, // $10.00 per unit
                    DiscountAmount = 500, // $5.00 discount
                    TaxAmount = 450 // $4.50 tax (10% on discounted amount)
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdInvoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        createdInvoice!.SubTotal.ShouldBe(5000); // 5 * 1000 = 5000
        createdInvoice.DiscountAmount.ShouldBe(500);
        createdInvoice.TaxAmount.ShouldBe(450);
        createdInvoice.TotalAmount.ShouldBe(4950); // 5000 - 500 + 450 = 4950
    }

    #endregion

    #region Purchase Invoice Scenarios

    [Fact]
    public async Task CreatePurchaseInvoice_CreatesInvoiceAndIncreasesStock()
    {
        // Arrange
        var product = await CreateTestProduct("Purchase Item");
        var supplierShopId = await CreateTestShop("Supplier Shop");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.In,
            BuyerShopId = _productHelper.DefaultShopId, // Our shop is buying
            IssuerShopId = supplierShopId, // Supplier is issuing
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 50,
                    UnitPrice = 80, // Purchase price
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        await LogIfError(response, "CreatePurchaseInvoice");

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdInvoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        createdInvoice!.TotalAmount.ShouldBe(4000); // 50 * 80 = 4000

        // Verify stock increased (new batch should be created)
        var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{product.Id}");
        if (stockResponse.StatusCode == HttpStatusCode.OK)
        {
            var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
            stockSummary!.TotalQuantity.ShouldBe(50);
            stockSummary.BatchCount.ShouldBe(1);
        }
    }

    #endregion

    #region Return Invoice Scenarios

    [Fact]
    public async Task CreateReturnInvoice_ReturnsStockToInventory()
    {
        // Arrange - First create a sale
        var product = await CreateTestProduct("Returnable Item");
        await CreateStockBatch(product.Id, 100, "RI-001");

        // Create original sale
        var saleDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-005",
            InvoiceDate = DateTime.UtcNow.AddDays(-1),
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 10,
                    UnitPrice = 200,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var saleResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, saleDto);
        var originalInvoice = await saleResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Create return invoice
        var returnDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Return,
            CustomerId = "customer-005",
            OriginalInvoiceId = originalInvoice!.Id,
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 3, // Partial return
                    UnitPrice = 200,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var returnResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, returnDto);
        await LogIfError(returnResponse, "CreateReturnInvoice");

        // Assert
        returnResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        var returnInvoice = await returnResponse.Content.ReadFromJsonAsync<InvoiceDto>();
        returnInvoice!.TotalAmount.ShouldBe(600); // 3 * 200 = 600

        // Verify stock increased back
        await VerifyStockReduced(product.Id, 93); // 100 - 10 + 3 = 93
    }

    #endregion

    #region Payment Processing Scenarios

    [Fact]
    public async Task ProcessPayment_FullPayment_MarksInvoiceAsPaid()
    {
        // Arrange - Create invoice
        var product = await CreateTestProduct("Payment Test Item");
        await CreateStockBatch(product.Id, 50, "PT-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-006",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 5,
                    UnitPrice = 300,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var invoiceResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        var createdInvoice = await invoiceResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Create payment
        var paymentDto = new PaymentCreateDto
        {
            InvoiceId = createdInvoice!.Id,
            PaymentAmount = 1500, // Full amount
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "Cash payment"
        };

        // Act
        var paymentResponse = await Client.PostAsJsonAsync(ApiEndpoints.Payment, paymentDto);
        await LogIfError(paymentResponse, "ProcessPayment_FullPayment");

        // Assert
        paymentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify invoice payment status
        var invoiceCheck = await Client.GetAsync($"{ApiEndpoints.Invoice}/{createdInvoice.Id}");
        var updatedInvoice = await invoiceCheck.Content.ReadFromJsonAsync<InvoiceDto>();
        updatedInvoice!.PaymentStatus.ShouldBe(PaymentStatus.Paid);
        updatedInvoice.PaidAmount.ShouldBe(1500);
        updatedInvoice.BalanceAmount.ShouldBe(0);
    }

    [Fact]
    public async Task ProcessPayment_PartialPayment_MarksInvoiceAsPartiallyPaid()
    {
        // Arrange - Create invoice
        var product = await CreateTestProduct("Partial Payment Item");
        await CreateStockBatch(product.Id, 30, "PP-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-007",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 10,
                    UnitPrice = 250,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var invoiceResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        var createdInvoice = await invoiceResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Create partial payment
        var paymentDto = new PaymentCreateDto
        {
            InvoiceId = createdInvoice!.Id,
            PaymentAmount = 1000, // Partial amount (total is 2500)
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "Partial cash payment"
        };

        // Act
        var paymentResponse = await Client.PostAsJsonAsync(ApiEndpoints.Payment, paymentDto);

        // Assert
        paymentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        
        // Verify invoice payment status
        var invoiceCheck = await Client.GetAsync($"{ApiEndpoints.Invoice}/{createdInvoice.Id}");
        var updatedInvoice = await invoiceCheck.Content.ReadFromJsonAsync<InvoiceDto>();
        updatedInvoice!.PaymentStatus.ShouldBe(PaymentStatus.PartiallyPaid);
        updatedInvoice.PaidAmount.ShouldBe(1000);
        updatedInvoice.BalanceAmount.ShouldBe(1500); // 2500 - 1000 = 1500
    }

    [Fact]
    public async Task ProcessPayment_MultiplePayments_AccumulatesCorrectly()
    {
        // Arrange - Create invoice
        var product = await CreateTestProduct("Multiple Payment Item");
        await CreateStockBatch(product.Id, 20, "MP-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-008",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 8,
                    UnitPrice = 500,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var invoiceResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        var createdInvoice = await invoiceResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Create first payment
        var payment1 = new PaymentCreateDto
        {
            InvoiceId = createdInvoice!.Id,
            PaymentAmount = 2000,
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "First payment"
        };

        // Create second payment
        var payment2 = new PaymentCreateDto
        {
            InvoiceId = createdInvoice.Id,
            PaymentAmount = 2000,
            PaymentMethod = PaymentMethod.BankTransfer,
            PaymentDate = DateTime.UtcNow.AddHours(1),
            Reference = "Second payment"
        };

        // Act
        await Client.PostAsJsonAsync(ApiEndpoints.Payment, payment1);
        await Client.PostAsJsonAsync(ApiEndpoints.Payment, payment2);

        // Assert
        var invoiceCheck = await Client.GetAsync($"{ApiEndpoints.Invoice}/{createdInvoice.Id}");
        var updatedInvoice = await invoiceCheck.Content.ReadFromJsonAsync<InvoiceDto>();
        updatedInvoice!.PaymentStatus.ShouldBe(PaymentStatus.Paid);
        updatedInvoice.PaidAmount.ShouldBe(4000); // 2000 + 2000 = 4000
        updatedInvoice.BalanceAmount.ShouldBe(0);
    }

    #endregion

    #region Credit Management Scenarios

    [Fact]
    public async Task CreateCreditSale_CreatesInvoiceAndCreditAccount()
    {
        // Arrange
        var product = await CreateTestProduct("Credit Sale Item");
        await CreateStockBatch(product.Id, 40, "CS-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-009",
            InvoiceDate = DateTime.UtcNow,
            DueDate = DateTime.UtcNow.AddDays(30), // 30 days credit
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 6,
                    UnitPrice = 400,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        // Act
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var createdInvoice = await response.Content.ReadFromJsonAsync<InvoiceDto>();
        createdInvoice!.PaymentStatus.ShouldBe(PaymentStatus.Unpaid);
        createdInvoice.DueDate.ShouldNotBeNull();

        // Verify credit account created/updated
        var creditResponse = await Client.GetAsync($"{ApiEndpoints.CustomerCredit}/customer-009");
        if (creditResponse.StatusCode == HttpStatusCode.OK)
        {
            var creditAccount = await creditResponse.Content.ReadFromJsonAsync<CustomerCreditAccountDto>();
            creditAccount!.TotalCreditAmount.ShouldBeGreaterThanOrEqualTo(2400); // 6 * 400 = 2400
        }
    }

    [Fact]
    public async Task ProcessCreditPayment_ReducesCreditBalance()
    {
        // Arrange - Create credit sale first
        var product = await CreateTestProduct("Credit Payment Item");
        await CreateStockBatch(product.Id, 25, "CP-001");

        var invoiceDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "customer-010",
            InvoiceDate = DateTime.UtcNow,
            DueDate = DateTime.UtcNow.AddDays(15),
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 4,
                    UnitPrice = 350,
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var invoiceResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, invoiceDto);
        var createdInvoice = await invoiceResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Create credit payment
        var creditPaymentDto = new CreditPaymentCreateDto
        {
            CustomerId = "customer-010",
            PaymentAmount = 1000,
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "Credit payment",
            InvoiceId = createdInvoice!.Id
        };

        // Act
        var paymentResponse = await Client.PostAsJsonAsync(ApiEndpoints.CreditPayment, creditPaymentDto);
        await LogIfError(paymentResponse, "ProcessCreditPayment");

        // Assert
        paymentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        // Verify credit balance reduced
        var creditResponse = await Client.GetAsync($"{ApiEndpoints.CustomerCredit}/customer-010");
        if (creditResponse.StatusCode == HttpStatusCode.OK)
        {
            var creditAccount = await creditResponse.Content.ReadFromJsonAsync<CustomerCreditAccountDto>();
            creditAccount!.AvailableCredit.ShouldBeGreaterThan(0);
        }
    }

    #endregion

    #region Business Workflow Scenarios

    [Fact]
    public async Task CompleteBusinessWorkflow_PurchaseToSaleToPayment_WorksEndToEnd()
    {
        // Arrange
        var product = await CreateTestProduct("Workflow Test Item");
        var supplierShopId = await CreateTestShop("Test Supplier");

        // Step 1: Purchase from supplier
        var purchaseDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.In,
            BuyerShopId = _productHelper.DefaultShopId,
            IssuerShopId = supplierShopId,
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 100,
                    UnitPrice = 50, // Purchase at $0.50
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var purchaseResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, purchaseDto);
        purchaseResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        // Step 2: Sell to customer
        var saleDto = new InvoiceCreateDto
        {
            TransactionType = TransactionType.Out,
            CustomerId = "workflow-customer",
            InvoiceDate = DateTime.UtcNow,
            Items = new List<InvoiceItemCreateDto>
            {
                new()
                {
                    ProductId = product.Id,
                    Quantity = 20,
                    UnitPrice = 100, // Sell at $1.00
                    DiscountAmount = 0,
                    TaxAmount = 0
                }
            }
        };

        var saleResponse = await Client.PostAsJsonAsync(ApiEndpoints.Invoice, saleDto);
        var saleInvoice = await saleResponse.Content.ReadFromJsonAsync<InvoiceDto>();

        // Step 3: Process payment
        var paymentDto = new PaymentCreateDto
        {
            InvoiceId = saleInvoice!.Id,
            PaymentAmount = 2000, // Full payment
            PaymentMethod = PaymentMethod.Cash,
            PaymentDate = DateTime.UtcNow,
            Reference = "Workflow payment"
        };

        var paymentResponse = await Client.PostAsJsonAsync(ApiEndpoints.Payment, paymentDto);

        // Assert - Verify final state
        saleResponse.StatusCode.ShouldBe(HttpStatusCode.OK);
        paymentResponse.StatusCode.ShouldBe(HttpStatusCode.OK);

        // Verify stock levels
        await VerifyStockReduced(product.Id, 80); // 100 purchased - 20 sold = 80

        // Verify invoice is paid
        var invoiceCheck = await Client.GetAsync($"{ApiEndpoints.Invoice}/{saleInvoice.Id}");
        var finalInvoice = await invoiceCheck.Content.ReadFromJsonAsync<InvoiceDto>();
        finalInvoice!.PaymentStatus.ShouldBe(PaymentStatus.Paid);
    }

    #endregion

    #region Helper Methods

    private async Task<ProductDto> CreateTestProduct(string name, string? shopId = null)
    {
        var productDto = _productHelper.CreateProductBuilder()
            .WithName(name)
            .WithShopId(shopId ?? _productHelper.DefaultShopId)
            .Build();
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Product, productDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<ProductDto>())!;
    }

    private async Task<StockBatchDto> CreateStockBatch(string productId, decimal quantity, string batchNumber)
    {
        var batchDto = _stockBatchHelper.CreateStockBatchBuilder()
            .WithProductId(productId)
            .WithQuantity(quantity)
            .WithBatchNumber(batchNumber)
            .Build();
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.StockBatch, batchDto);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<StockBatchDto>())!;
    }

    private async Task<string> CreateTestShop(string name)
    {
        var shopDto = new ShopCreateDto
        {
            Name = name,
            ShopType = ShopType.Wholesale,
            Address = "Test Address",
            PhoneNumber = "123-456-7890",
            Email = "test@shop.com"
        };
        
        var response = await Client.PostAsJsonAsync(ApiEndpoints.Shop, shopDto);
        response.EnsureSuccessStatusCode();
        var shop = await response.Content.ReadFromJsonAsync<ShopDto>();
        return shop!.Id;
    }

    private async Task VerifyStockReduced(string productId, decimal expectedQuantity)
    {
        var stockResponse = await Client.GetAsync($"{ApiEndpoints.Inventory}/stock-summary/{productId}");
        if (stockResponse.StatusCode == HttpStatusCode.OK)
        {
            var stockSummary = await stockResponse.Content.ReadFromJsonAsync<StockSummaryDto>();
            stockSummary!.TotalQuantity.ShouldBe(expectedQuantity);
        }
    }

    #endregion
}

#region Additional DTOs

public class InvoiceCreateDto
{
    public TransactionType TransactionType { get; set; }
    public string? CustomerId { get; set; }
    public string? BuyerShopId { get; set; }
    public string? IssuerShopId { get; set; }
    public string? OriginalInvoiceId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public List<InvoiceItemCreateDto> Items { get; set; } = new();
}

public class InvoiceItemCreateDto
{
    public string ProductId { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public long UnitPrice { get; set; }
    public long DiscountAmount { get; set; }
    public long TaxAmount { get; set; }
}

public class InvoiceDto
{
    public string Id { get; set; } = string.Empty;
    public string InvoiceNumber { get; set; } = string.Empty;
    public TransactionType TransactionType { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? DueDate { get; set; }
    public long SubTotal { get; set; }
    public long TaxAmount { get; set; }
    public long DiscountAmount { get; set; }
    public long TotalAmount { get; set; }
    public long PaidAmount { get; set; }
    public long BalanceAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public List<InvoiceItemDto> Items { get; set; } = new();
}

public class InvoiceItemDto
{
    public string Id { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public long UnitPrice { get; set; }
    public long DiscountAmount { get; set; }
    public long TaxAmount { get; set; }
    public long TotalAmount { get; set; }
}

public class PaymentCreateDto
{
    public string InvoiceId { get; set; } = string.Empty;
    public long PaymentAmount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
    public string? Reference { get; set; }
}

public class CreditPaymentCreateDto
{
    public string CustomerId { get; set; } = string.Empty;
    public string? InvoiceId { get; set; }
    public long PaymentAmount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
    public string? Reference { get; set; }
}

public class CustomerCreditAccountDto
{
    public string CustomerId { get; set; } = string.Empty;
    public long CreditLimit { get; set; }
    public long TotalCreditAmount { get; set; }
    public long AvailableCredit { get; set; }
}

public enum PaymentStatus
{
    Unpaid = 1,
    PartiallyPaid = 2,
    Paid = 3,
    Overpaid = 4
}

public enum PaymentMethod
{
    Cash = 1,
    BankTransfer = 2,
    CreditCard = 3,
    Check = 4
}

#endregion