namespace Xod.Internals;

internal class XMasterDetails
{
    public XFile Master { get; set; }
    public List<XMasterDetails> Details { get; set; }

    public XMasterDetails()
    {
        Details = new List<XMasterDetails>();
    }
}