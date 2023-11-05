using Xod.Flags;
using Xod.Internals;

namespace Xod.Caching;

internal class FileCache
{
    public string FileName { get; set; }
    public XFile File { get; set; }
    public DateTime LastCheckout { get; set; }
    public FileCacheStatus Status { get; set; }
}