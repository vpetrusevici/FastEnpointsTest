namespace FastEnpointsTest
{
    public class ArticleMetaInfoDto
    {
        #region OpenGraph
        public string? OgTitle { get; init; }
        public string? OgImage { get; init; }
        public string? OgDescription { get; init; }
        public string? OgVideo { get; init; }
        #endregion

        #region TwitterCards
        public string? TwImage { get; init; }
        public string? TwDescription { get; init; }
        public string? TwTitle { get; init; }
        #endregion

        #region VkTags
        public string? VkImage { get; init; }
        #endregion

    }
}