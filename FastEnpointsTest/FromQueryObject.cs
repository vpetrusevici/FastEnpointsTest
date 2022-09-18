namespace FastEnpointsTest
{
    public class FromQueryObject
    {
        public string? Id { get; init; }
        public int? Count { get; init; }
        public string? Pony { get; init; }
        public NestedFromQueryObject Nested { get; init; } = null!;
    }
}
