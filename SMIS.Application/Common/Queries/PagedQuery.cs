namespace SMIS.Application.Common.Queries;

/// <summary>
/// Base contract for reflection-driven paged queries. Derived query DTOs add filter
/// properties; GenericQueryService matches those properties to entity properties by name.
/// </summary>
public abstract class PagedQuery
{
    public const int DefaultPageSize = 25;
    public const int MaxPageSize = 100;

    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = DefaultPageSize;
}
