namespace Xod.Internals;

internal class ReadWriteTrack
{
    public object Item { get; set; }
    public Type Type { get; set; }
    public string Code { get; set; }
    public ReadWriteTrack Parent { get; set; }

    public PropertyInfoItem RootProperty { get; set; }
    public Guid ReadId { get; set; }
}