using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Application.Repositories.Products;
using SMIS.Application.Repositories.Shops;
using SMIS.Application.Repositories.UnitOfMeasures;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountUpdateCommand(string Id, LoanAccountCreateDto LoanAccountCreateDto) : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountUpdateCommandHandler : IRequestHandler<LoanAccountUpdateCommand, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IShopRepository _shopRepository;
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfMeasureRepository _unitOfMeasureRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LoanAccountUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoanAccountRepository loanAccountRepository, ICustomerRepository customerRepository, IShopRepository shopRepository, IProductRepository productRepository, IUnitOfMeasureRepository unitOfMeasureRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _loanAccountRepository = loanAccountRepository;
        _customerRepository = customerRepository;
        _shopRepository = shopRepository;
        _productRepository = productRepository;
        _unitOfMeasureRepository = unitOfMeasureRepository;
    }

    public async Task<Result<LoanAccountDto>> Handle(LoanAccountUpdateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _loanAccountRepository.GetByIdAsync(request.Id);
        if (entity == null)
        {
            return Result<LoanAccountDto>.NotFoundResult(nameof(LoanAccountDto.Id));
        }

        entity.SetCustomerId(request.LoanAccountCreateDto.CustomerId);
        entity.SetShopId(request.LoanAccountCreateDto.ShopId);
        entity.SetProductId(request.LoanAccountCreateDto.ProductId);
        entity.SetQuantity(request.LoanAccountCreateDto.Quantity);
        entity.SetUnitId(request.LoanAccountCreateDto.UnitId);
        entity.SetPriceAtLoanTime(request.LoanAccountCreateDto.PriceAtLoanTime);
        entity.SetTotalAmount(request.LoanAccountCreateDto.TotalAmount);
        entity.SetDueDate(request.LoanAccountCreateDto.DueDate);
        entity.SetNotes(request.LoanAccountCreateDto.Notes);
        
        var customer = await _customerRepository.GetByIdAsync(request.LoanAccountCreateDto.CustomerId);
        entity.CustomerName = customer?.FirstName;
        
        var shop = await _shopRepository.GetByIdAsync(request.LoanAccountCreateDto.ShopId);
        entity.ShopName = shop?.Name;
        
        var product = await _productRepository.GetByIdAsync(request.LoanAccountCreateDto.ProductId);
        entity.ProductName = product?.Name;
        
        var unit = await _unitOfMeasureRepository.GetByIdAsync(request.LoanAccountCreateDto.UnitId);
        entity.UnitName = unit?.Name;
        
        await _unitOfWork.SaveChanges(cancellationToken);

        var dto = _mapper.Map<LoanAccountDto>(entity);
        return Result<LoanAccountDto>.SuccessResult(dto);
    }
}
