using Xod.Attributes;
using Xod.Flags;

namespace Xod.Internals;

internal class TablePage
{
    [Property(Position = ValuePosition.Attribute)]
    public bool Full { get; set; }
    public List<PageRow> Rows { get; set; }

    public TablePage()
    {
        Rows = new List<PageRow>();
    }
}