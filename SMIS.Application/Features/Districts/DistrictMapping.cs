using SMIS.Application.DTO.Districts;
using SMIS.Domain.Entities.LocationEntities;

namespace SMIS.Application.Features.Districts;

internal static class DistrictMapping
{
    public static District Create(DistrictCreateDto dto) => new() { Name = dto.Name };

    public static void Apply(District district, DistrictCreateDto dto) => district.Name = dto.Name;

    public static DistrictDto ToDto(District district) => new()
    {
        Id = district.Id,
        Name = district.Name
    };
}
