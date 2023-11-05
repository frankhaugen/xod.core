using Xod.Caching;

namespace Xod.Internals;

internal class Table
{
    public string Name { get; set; }
    public List<TablePage> Pages { get; set; }
    public List<PageIndex> Indexes { get; set; }
    AutonumberCache Seed { get; set; }

    public Table()
    {
        Pages = new List<TablePage>();
    }
}