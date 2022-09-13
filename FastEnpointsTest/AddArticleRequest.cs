using FastEndpoints;

namespace FastEnpointsTest
{
    public class AddArticleRequest
    {
        [QueryParam]
        public string? Id { get; init; }
        public string LocaleName { get; init; } = null!;
        [FromBody]
        public ArticleAddDto Article { get; init; } = null!;

    }
}
