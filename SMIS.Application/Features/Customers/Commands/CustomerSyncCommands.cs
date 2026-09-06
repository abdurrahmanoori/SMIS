using AutoMapper;
using MediatR;
using SMIS.Application.Common.Response;
using SMIS.Application.DTO.Customers;
using SMIS.Application.Identity.IServices;
using SMIS.Application.Repositories.Base;
using SMIS.Application.Repositories.Customers;
using SMIS.Domain.Entities;
using SMIS.Domain.Services;

namespace SMIS.Application.Features.Customers.Commands;

public record CustomerSyncCreateCommand(CustomerSyncCreateDto Dto) : IRequest<Result<CustomerDto>>;
public record CustomerSyncUpdateCommand(string Id, CustomerSyncUpdateDto Dto) : IRequest<Result<CustomerDto>>;
public record CustomerSyncDeleteCommand(string Id, CustomerSyncDeleteDto Dto) : IRequest<Result<CustomerDto>>;

internal sealed class CustomerSyncCreateCommandHandler : IRequestHandler<CustomerSyncCreateCommand, Result<CustomerDto>>
{
    private readonly ICustomerRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;
    public CustomerSyncCreateCommandHandler(ICustomerRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);

    public async Task<Result<CustomerDto>> Handle(CustomerSyncCreateCommand request, CancellationToken cancellationToken)
    {
        var id = CustomerSyncRules.NormalizeGuid(request.Dto.Id);
        if (!CustomerSyncRules.UserMatches(request.Dto.ClientCreatedBy, _currentUser) || !CustomerSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser)) return CustomerSyncRules.InvalidUser();
        var existing = await _repository.GetByIdIncludingDeletedAsync(id, cancellationToken);
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (existing is not null)
        {
            if (!CustomerSyncRules.CanAccess(existing, _currentUser)) return CustomerSyncRules.Forbidden();
            if (modified <= existing.GetConflictModifiedUtc()) return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(existing));
            CustomerSyncRules.Apply(existing, request.Dto);
            existing.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
            existing.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
            existing.Restore();
            await _unitOfWork.SaveChanges(cancellationToken);
            return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(existing));
        }
        var customer = Customer.Create(request.Dto.FirstName, _currentUser.GetShopId(), request.Dto.CustomerType, request.Dto.LastName, request.Dto.FatherName, request.Dto.Email, request.Dto.PhoneNumber, request.Dto.Address, request.Dto.TaxNumber, request.Dto.ProvinceId, request.Dto.DistrictId, request.Dto.IsActive);
        customer.Id = id;
        customer.SetClientCreationMetadata(request.Dto.ClientCreatedDate, request.Dto.ClientCreatedBy);
        customer.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy);
        await _repository.AddAsync(customer);
        await _unitOfWork.SaveChanges(cancellationToken);
        return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(customer));
    }
}

internal sealed class CustomerSyncUpdateCommandHandler : IRequestHandler<CustomerSyncUpdateCommand, Result<CustomerDto>>
{
    private readonly ICustomerRepository _repository; private readonly IUnitOfWork _unitOfWork; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public CustomerSyncUpdateCommandHandler(ICustomerRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);
    public async Task<Result<CustomerDto>> Handle(CustomerSyncUpdateCommand request, CancellationToken cancellationToken)
    {
        if (!CustomerSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser)) return CustomerSyncRules.InvalidUser();
        var customer = await _repository.GetByIdIncludingDeletedAsync(CustomerSyncRules.NormalizeGuid(request.Id), cancellationToken);
        if (customer is null) return Result<CustomerDto>.NotFoundResult(request.Id);
        if (!CustomerSyncRules.CanAccess(customer, _currentUser)) return CustomerSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= customer.GetConflictModifiedUtc()) return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(customer));
        CustomerSyncRules.Apply(customer, request.Dto); customer.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); customer.Restore();
        await _unitOfWork.SaveChanges(cancellationToken); return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(customer));
    }
}

internal sealed class CustomerSyncDeleteCommandHandler : IRequestHandler<CustomerSyncDeleteCommand, Result<CustomerDto>>
{
    private readonly ICustomerRepository _repository; private readonly IUnitOfWork _unitOfWork; private readonly ICurrentUser _currentUser; private readonly IMapper _mapper;
    public CustomerSyncDeleteCommandHandler(ICustomerRepository repository, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper) => (_repository, _unitOfWork, _currentUser, _mapper) = (repository, unitOfWork, currentUser, mapper);
    public async Task<Result<CustomerDto>> Handle(CustomerSyncDeleteCommand request, CancellationToken cancellationToken)
    {
        if (!CustomerSyncRules.UserMatches(request.Dto.ClientModifiedBy, _currentUser)) return CustomerSyncRules.InvalidUser();
        var customer = await _repository.GetByIdIncludingDeletedAsync(CustomerSyncRules.NormalizeGuid(request.Id), cancellationToken);
        if (customer is null) return Result<CustomerDto>.NotFoundResult(request.Id);
        if (!CustomerSyncRules.CanAccess(customer, _currentUser)) return CustomerSyncRules.Forbidden();
        var modified = DateTimeService.NormalizeUtc(request.Dto.ClientModifiedDate);
        if (modified <= customer.GetConflictModifiedUtc()) return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(customer));
        customer.SetClientModificationMetadata(modified, request.Dto.ClientModifiedBy); await _repository.RemoveAsync(customer); await _unitOfWork.SaveChanges(cancellationToken);
        return Result<CustomerDto>.SuccessResult(_mapper.Map<CustomerDto>(customer));
    }
}

internal static class CustomerSyncRules
{
    public static string NormalizeGuid(string value) => Guid.Parse(value).ToString("D");
    public static bool UserMatches(string? value, ICurrentUser currentUser) => string.IsNullOrWhiteSpace(value) || string.Equals(value.Trim(), currentUser.GetId(), StringComparison.Ordinal);
    public static bool CanAccess(Customer customer, ICurrentUser currentUser) => currentUser.IsSuperAdmin() || customer.ShopId == currentUser.GetShopId();
    public static void Apply(Customer customer, CustomerCreateDto dto)
    {
        customer.SetFirstName(dto.FirstName); customer.SetCustomerType(dto.CustomerType); customer.SetLastName(dto.LastName); customer.SetFatherName(dto.FatherName); customer.SetEmail(dto.Email); customer.SetPhoneNumber(dto.PhoneNumber); customer.SetAddress(dto.Address); customer.SetTaxNumber(dto.TaxNumber); customer.SetProvinceId(dto.ProvinceId); customer.SetDistrictId(dto.DistrictId);
        if (dto.IsActive) customer.Activate(); else customer.Deactivate();
    }
    public static Result<CustomerDto> InvalidUser() => Result<CustomerDto>.FailureResult("InvalidClientUser", "Client user metadata must match the authenticated user.");
    public static Result<CustomerDto> Forbidden() => Result<CustomerDto>.FailureResult("Forbidden", "You can only synchronize customers from your own shop.");
}
