namespace Xod.Caching;

internal interface ICachedList<T> : IDisposable
{
    List<T> GetItems();
}