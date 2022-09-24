using FastEndpoints;

namespace FastEnpointsTest
{
    public class GetArticleRequest
    {
        [FromQueryParams]
        public PaginationFilterWithTextAndSort<AdminArticlesSortColumn> Filter { get; init; } = null!;
        public string LocaleName { get; init; } = null!;

    }

    public class GetAnotherArticleRequest
    {
        [FromQueryParams]
        public PaginationFilterWithTextAndSort<AnotherAdminArticlesSortColumn> Filter { get; init; } = null!;
        public string LocaleName { get; init; } = null!;

    }
    public enum AnotherAdminArticlesSortColumn : byte
    {
        Title,
        Author,
        DateOfCreation
    }
    public enum AdminArticlesSortColumn : byte
    {
        Title,
        Author,
        DateOfCreation
    }
    public class PaginationFilterWithTextAndSort<T> : PaginationFilterWithTextAndSort where T : struct, Enum
    {
        public T SortByColumn { get; init; }
    }

    public class PaginationFilterWithTextAndSort : PaginationFilterWithText
    {
        public bool SortByAscending { get; init; }
    }

    public class PaginationFilterWithText : PaginationFilter
    {
        public string? FilterText { get; init; }
    }

    public class PaginationFilter
    {
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
    }
}
