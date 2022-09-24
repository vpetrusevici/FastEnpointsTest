using FastEndpoints;

namespace FastEnpointsTest
{
    public class AddArticleEndpoint : Endpoint<GetArticleRequest, string>
    {

        public override void Configure()
        {
            Get("api/admin/articles/{LocaleName:length(2):alpha}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetArticleRequest request, CancellationToken cancellationToken)
        { }
    }

    public class AnotherGetArticleEndpoint : Endpoint<GetAnotherArticleRequest, string>
    {

        public override void Configure()
        {
            Get("api/admin/articles2/{LocaleName:length(2):alpha}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetAnotherArticleRequest request, CancellationToken cancellationToken)
        { }
    }
}
