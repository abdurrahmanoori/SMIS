using SMIS.Application.DTO.Customers;
using SMIS.Domain.Entities;

namespace SMIS.Application.Features.Customers;

internal static class CustomerMapping
{
    public static CustomerDto ToDto(Customer customer) => new()
    {
        Id = customer.Id,
        FirstName = customer.FirstName,
        LastName = customer.LastName,
        ShopId = customer.ShopId,
        ShopName = customer.ShopName,
        CustomerType = customer.CustomerType,
        FatherName = customer.FatherName,
        Email = customer.Email,
        PhoneNumber = customer.PhoneNumber,
        Address = customer.Address,
        TaxNumber = customer.TaxNumber,
        ProvinceId = customer.ProvinceId,
        DistrictId = customer.DistrictId,
        IsActive = customer.IsActive,
        CreatedDate = AsUtc(customer.CreatedDate),
        CreatedBy = customer.CreatedBy,
        UpdatedDate = AsUtc(customer.UpdatedDate),
        UpdatedBy = customer.UpdatedBy,
        LastModifiedUtc = AsUtc(customer.LastModifiedUtc),
        IsDeleted = customer.IsDeleted
    };

    private static DateTime AsUtc(DateTime value) => value.Kind switch
    {
        DateTimeKind.Utc => value,
        DateTimeKind.Local => value.ToUniversalTime(),
        _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
    };

    private static DateTime? AsUtc(DateTime? value) =>
        value.HasValue ? AsUtc(value.Value) : null;
}
