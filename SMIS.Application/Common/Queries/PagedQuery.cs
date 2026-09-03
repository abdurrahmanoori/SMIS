namespace SMIS.Application.Common.Queries;

public abstract class PagedQuery
{
    public const int DefaultPageSize = 25;
    public const int MaxPageSize = 100;

    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = DefaultPageSize;
}
