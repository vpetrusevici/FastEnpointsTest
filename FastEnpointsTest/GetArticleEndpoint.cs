using FastEndpoints;

namespace FastEnpointsTest
{
    public class GetArticleEndpoint : Endpoint<PaginationFilterWithTextAndSort<AdminArticlesSortColumn>, string>
    {

        public override void Configure()
        {
            Get("api/admin/articles2/{LocaleName:length(2):alpha}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(PaginationFilterWithTextAndSort<AdminArticlesSortColumn> request, CancellationToken cancellationToken)
        { }
    }
}
