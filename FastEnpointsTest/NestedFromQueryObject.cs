namespace FastEnpointsTest
{
    public class NestedFromQueryObject
    {
        public string? NestedId { get; init; }
        public int? NestedCount { get; init; }
        public string? NestedPony { get; init; }
        public List<string> SecondChilds { get; init; } = null!;
    }
}
