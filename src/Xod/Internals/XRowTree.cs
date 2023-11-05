using System.Xml.Linq;

namespace Xod.Internals;

internal class XRowTree
{
    public XFile Table { get; set; }
    public XFile Page { get; set; }
    public List<XElement> Rows { get; set; }
}