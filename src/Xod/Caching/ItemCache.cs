namespace Xod.Caching;

internal class ItemCache
{
    public string Code { get; set; }
    public Type Type { get; set; }
    public object Item { get; set; }
    public bool LazyLoaded { get; set; }
    public string[] IncludedReferenceProperties { get; set; }
    public DateTime LoadTime { get; set; }

    public Guid ReadId { get; set; }
    public Guid ParentReadId { get; set; }
    public bool ParentIsLeaf { get; set; }
}