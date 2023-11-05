namespace Xod;

public static class NumericOperations
{
    public static T Sum<T>(object[] args)
    {
        dynamic value = default(T);
        foreach (var arg in args)
            value += (T)arg;
        return value;
    }
}