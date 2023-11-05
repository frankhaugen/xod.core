namespace Xod.Internals;

internal class IndexRange
{
    public Type Type { get; set; }
    public Type PropertyType { get; set; }
    public string PropertyName { get; set; }

    public dynamic Begins { get; set; }
    public dynamic Ends { get; set; }

    public dynamic Pattern { get; set; }

    public string Page { get; set; }
}