namespace FastEnpointsTest
{
    public class FromQueryObject
    {
        public string? Id { get; init; }
        public int? Count { get; init; }
        public string? Pony { get; init; }
        public List<string> StringList { get; init; } = null!;
        public NestedFromQueryObject Nested { get; init; } = null!;
    }
}
