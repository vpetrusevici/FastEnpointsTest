namespace FastEnpointsTest
{
    public class ArticleAddDto
    {
        public string Title { get; init; } = null!;
        public string? Subtitle { get; init; }
        public string? Description { get; init; }
        public bool IsDraft { get; init; }
        public bool DisplayMainImageInArticle { get; init; }
        public int CategoryId { get; init; }
        public DateTimeOffset PublicationDate { get; init; }
        public List<string> Authors { get; init; } = new List<string>();
        public string BaseLinkUrl { get; init; } = null!;
        public bool SendNotification { get; init; }
        public List<ArticleMetaInfoDto> ArticleMetaInfo { get; init; } = null!;

    }

}