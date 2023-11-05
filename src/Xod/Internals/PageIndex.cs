using Xod.Attributes;
using Xod.Flags;

namespace Xod.Internals;

internal class PageIndex
{
    [Property(Position = ValuePosition.Attribute)]
    public string Begins { get; set; }
    [Property(Position = ValuePosition.Attribute)]
    public string Ends { get; set; }
}