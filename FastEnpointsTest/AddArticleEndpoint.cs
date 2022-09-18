using FastEndpoints;

namespace FastEnpointsTest
{
    public class AddArticleEndpoint : Endpoint<AddArticleRequest, string>
    {

        public override void Configure()
        {
            Post("api/admin/articles/{LocaleName:length(2):alpha}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(AddArticleRequest request, CancellationToken cancellationToken)
        { }
    }

}
