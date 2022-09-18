namespace FastEnpointsTest
{
    public class NestedFromQueryObject
    {
        public string? NestedId { get; init; }
        public int? NestedCount { get; init; }
        public string? NestedPony { get; init; }
        public MoreNestedFromQueryObject SecondChild { get; init; } = null!;
    }
}
