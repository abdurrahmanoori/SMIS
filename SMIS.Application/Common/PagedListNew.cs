using Microsoft.EntityFrameworkCore;

namespace SMIS.Application.Common
{
    public class PagedListNew<T>
    {
        private const int DefaultPageSize = 25;
        private const int DefaultPageNumber = 1;

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public List<T> Items { get; set; } = new List<T>();

        public static async Task<PagedListNew<T>> CreateList(
            IQueryable<T> entities,
            int pageNumber,
            int pageSize,
            CancellationToken ct = default
        )
        {
            pageNumber = pageNumber > 0 ? pageNumber : DefaultPageNumber;
            pageSize = pageSize > 0 ? pageSize : DefaultPageSize;
            var count = await entities.CountAsync(ct);
            return new PagedListNew<T>()
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = count,
                TotalPages = CalculateTotalPages(count, pageSize),
                Items = await entities.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(ct)
            };
        }

        public static Task<PagedListNew<T>> CreateList(
            IQueryable<T> entities,
            int pageNumber
        )
        {
            return CreateList(entities, pageNumber, DefaultPageSize);
        }

        private static int CalculateTotalPages(
            int totalCount,
            int pageSize
        )
        {
            return (int)Math.Ceiling((double)totalCount / pageSize);
        }
    }

    public static partial class PagedListExtensions
    {
        public static async Task<PagedListNew<TEntity>> ToPagedList<TEntity>(
            this IQueryable<TEntity> queryable,
            int pageNumber,
            int pageSize,
            CancellationToken ct = default
        )
        {
            return await PagedListNew<TEntity>.CreateList(queryable, pageNumber, pageSize, ct);
        }

        public static async Task<PagedListNew<TEntity>> ToPagedList<TEntity>(
            this IQueryable<TEntity> queryable,
            int pageNumber
        )
        {
            return await PagedListNew<TEntity>.CreateList(queryable, pageNumber);
        }
    }
}