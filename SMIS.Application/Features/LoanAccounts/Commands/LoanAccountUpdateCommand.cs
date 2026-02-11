using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountUpdateCommand(string Id, LoanAccountCreateDto LoanAccountCreateDto) : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountUpdateCommandHandler : IRequestHandler<LoanAccountUpdateCommand, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LoanAccountUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoanAccountRepository loanAccountRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _loanAccountRepository = loanAccountRepository;
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
        
        await _unitOfWork.SaveChanges(cancellationToken);

        var dto = _mapper.Map<LoanAccountDto>(entity);
        return Result<LoanAccountDto>.SuccessResult(dto);
    }
}
