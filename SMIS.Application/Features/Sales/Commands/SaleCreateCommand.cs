using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Sales;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Application.Repositories.ProductUnits;
using SMIS.Application.Repositories.Sales;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Services;
using SMIS.Domain.Entities;
using SMIS.Domain.Enums;

namespace SMIS.Application.Features.Sales.Commands;

public sealed record SaleCreateCommand(SaleCreateDto Dto) : IRequest<Result<SaleDto>>;

internal sealed class SaleCreateCommandHandler : IRequestHandler<SaleCreateCommand, Result<SaleDto>>
{
    private readonly ISaleRepository _sales;
    private readonly ILoanAccountRepository _receivables;
    private readonly ICustomerRepository _customers;
    private readonly IShopRepository _shops;
    private readonly IProductUnitRepository _productUnits;
    private readonly IInventoryService _inventory;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;

    public SaleCreateCommandHandler(
        ISaleRepository sales,
        ILoanAccountRepository receivables,
        ICustomerRepository customers,
        IShopRepository shops,
        IProductUnitRepository productUnits,
        IInventoryService inventory,
        IUnitOfWork unitOfWork,
        ICurrentUser currentUser,
        IMapper mapper
    )
    {
        _sales = sales;
        _receivables = receivables;
        _customers = customers;
        _shops = shops;
        _productUnits = productUnits;
        _inventory = inventory;
        _unitOfWork = unitOfWork;
        _currentUser = currentUser;
        _mapper = mapper;
    }

    public async Task<Result<SaleDto>> Handle(
        SaleCreateCommand request,
        CancellationToken cancellationToken
    )
    {
        var dto = request.Dto;
        var shop = await _shops.GetByIdAsync(dto.ShopId);
        if (shop is null)
            return Result<SaleDto>.FailureResult("ShopNotFound", "The selected shop does not exist.");

        if (!_currentUser.IsSuperAdmin() &&
            !string.Equals(dto.ShopId, _currentUser.GetShopId(), StringComparison.Ordinal))
            return Result<SaleDto>.FailureResult("Forbidden", "You can only create sales for your own shop.");

        Customer? customer = null;
        if (!string.IsNullOrWhiteSpace(dto.CustomerId))
        {
            customer = await _customers.GetByIdAsync(dto.CustomerId);
            if (customer is null || customer.ShopId != dto.ShopId)
                return Result<SaleDto>.FailureResult(
                    "CustomerNotFoundOrForbidden",
                    "The selected customer does not belong to the sale shop.");
        }

        if (dto.PaymentType == SalePaymentType.Credit && customer is null)
            return Result<SaleDto>.FailureResult("CreditCustomerRequired", "Credit sales require a customer.");

        // Validate every commercial line before opening the transaction. Inventory repeats
        // its own validation because it is the authority for stock, while this check enforces
        // the sale-specific invariant that all lines belong to this sale's shop.
        foreach (var lineDto in dto.Lines)
        {
            var productUnit = await _productUnits.GetFirstOrDefaultAsync(
                unit => unit.Id == lineDto.ProductUnitId,
                includeProperties: "Product");

            if (productUnit?.Product is null || productUnit.ProductId != lineDto.ProductId)
                return Result<SaleDto>.FailureResult(
                    "ProductUnitMismatch",
                    "A selected product unit does not belong to its sale-line product.");

            if (productUnit.Product.ShopId != dto.ShopId)
                return Result<SaleDto>.FailureResult(
                    "SaleLineShopMismatch",
                    "All sale-line products must belong to the sale shop.");
        }

        var saleDate = dto.SaleDateUtc ?? DateTime.UtcNow;
        var sale = Sale.Create(dto.ShopId, dto.CustomerId, dto.PaymentType, saleDate, dto.Notes);

        foreach (var lineDto in dto.Lines)
        {
            sale.Lines.Add(SaleLine.Create(
                sale.Id,
                lineDto.ProductId,
                lineDto.ProductUnitId,
                lineDto.QuantityEntered,
                lineDto.UnitPrice));
        }

        sale.RecalculateTotal();
        if (dto.PaymentType == SalePaymentType.Credit && sale.TotalAmount <= 0)
            return Result<SaleDto>.FailureResult(
                "InvalidCreditAmount",
                "A credit sale must create a positive receivable amount.");

        await _sales.AddAsync(sale);

        // Every sale line issues stock immediately, whether the sale is Cash or Credit.
        // The inventory workflow only stages tracked batch changes and StockMovement rows;
        // this command owns the single SaveChanges call for the complete business operation.
        foreach (var line in sale.Lines)
        {
            var inventoryResult = await _inventory.IssueFifoAsync(
                new InventoryFifoIssueRequest(
                    line.ProductId,
                    line.ProductUnitId,
                    line.QuantityEntered,
                    StockMovementReason.Sale,
                    sale.SaleDateUtc,
                    nameof(SaleLine),
                    line.Id),
                cancellationToken);

            if (!inventoryResult.Success)
                return FailureFromInventory(inventoryResult);
        }

        if (sale.PaymentType == SalePaymentType.Credit)
        {
            var receivable = LoanAccount.Create(
                sale.Id,
                customer!.Id,
                sale.ShopId,
                sale.TotalAmount,
                sale.SaleDateUtc,
                dto.DueDate,
                dto.Notes);
            receivable.CustomerName = customer.FirstName;
            receivable.ShopName = shop.Name;

            sale.Receivable = receivable;
            await _receivables.AddAsync(receivable);
        }

        // Sale, lines, FIFO batch deductions, StockMovements, and the optional
        // receivable are committed atomically by EF Core in this single SaveChanges.
        await _unitOfWork.SaveChanges(cancellationToken);

        var result = _mapper.Map<SaleDto>(sale);
        result.ReceivableId = sale.Receivable?.Id;
        result.ReceivableRemainingAmount = sale.Receivable?.RemainingAmount;
        return Result<SaleDto>.SuccessResult(result);
    }

    private static Result<SaleDto> FailureFromInventory(
        Result<IReadOnlyList<StockMovement>> result
    ) =>
        new()
        {
            Success = false,
            Message = result.Message,
            Errors = result.Errors
        };
}