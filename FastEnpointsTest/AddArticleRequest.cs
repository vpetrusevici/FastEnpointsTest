using FastEndpoints;

namespace FastEnpointsTest
{
    public class AddArticleRequest
    {
        [FromQueryParams]
        public FromQueryObject? Query { get; init; }
        public string LocaleName { get; init; } = null!;
        [FromBody]
        public ArticleAddDto Article { get; init; } = null!;

    }
}
