using System.Xml.Linq;

namespace Xod.Internals;

internal class XRow
{
    public XFile Table { get; set; }
    public XFile Page { get; set; }
    public XElement Row { get; set; }
}