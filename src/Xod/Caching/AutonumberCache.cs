using System.Reflection;

namespace Xod.Caching;

internal class AutonumberCache
{
    public Type Type { get; set; }
    public string PropertyName { get; set; }
    public dynamic Value { get; set; }
    public MethodInfo Method { get; set; }
}