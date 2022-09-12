using FastEndpoints;

namespace FastEnpointsTest
{
    public class AddArticleRequest
    {
        [QueryParam]
        public string? Id { get; init; }
        public string LocaleName { get; init; } = null!;
        [FromBody]
        public List<string> Article { get; init; } = null!;

    }
}
