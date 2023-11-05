using Xod.Attributes;
using Xod.Flags;

namespace Xod.Internals;

internal class PageRow
{
    public string File { get; set; }
    [Property(Position = ValuePosition.Attribute)]
    public bool Full { get; set; }
}