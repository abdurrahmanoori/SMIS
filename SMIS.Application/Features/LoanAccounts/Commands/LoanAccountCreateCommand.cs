using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.LoanAccounts;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.LoanAccounts;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.LoanAccounts.Commands;

public record LoanAccountCreateCommand(LoanAccountCreateDto LoanAccountCreateDto) : IRequest<Result<LoanAccountDto>>;

internal sealed class LoanAccountCreateCommandHandler : IRequestHandler<LoanAccountCreateCommand, Result<LoanAccountDto>>
{
    private readonly ILoanAccountRepository _loanAccountRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LoanAccountCreateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILoanAccountRepository loanAccountRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _loanAccountRepository = loanAccountRepository;
    }

    public async Task<Result<LoanAccountDto>> Handle(LoanAccountCreateCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<LoanAccount>(request.LoanAccountCreateDto);
        
        await _loanAccountRepository.AddAsync(entity);
        await _unitOfWork.SaveChanges(cancellationToken);

        return Result<LoanAccountDto>.SuccessResult(_mapper.Map<LoanAccountDto>(entity));
    }
}
