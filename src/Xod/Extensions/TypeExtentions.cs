using System.Reflection;

namespace Xod.Extensions;

public static class TypeExtentions
{
    public static Type ActualType<T>(T param)
    {
        return typeof(T);
    }
    public static Type GetActualType(this object param)
    {
        if (null != param)
            return (Type)typeof(TypeExtentions)
                .GetTypeInfo()
                .GetMethod("ActualType")
                .MakeGenericMethod(new[] { param.GetType() })
                .Invoke(null, new[] { param });
        else
            return null;
    }
    public static object ToType(this object obj, Type type)
    {
        object tmp = Activator.CreateInstance(type);

        try
        {
            foreach (var pi in obj.GetType().GetProperties())
            {
                tmp.GetType().GetProperty(pi.Name).SetValue(tmp, pi.GetValue(obj, null), null);
            }
        }
        catch (Exception ex)
        {
        }

        return tmp;
    }
    public static bool ArraysEqual<T>(T[] a1, T[] a2)
    {
        if (ReferenceEquals(a1, a2))
            return true;

        if (a1 == null || a2 == null)
            return false;

        if (a1.Length != a2.Length)
            return false;

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        for (int i = 0; i < a1.Length; i++)
        {
            if (!comparer.Equals(a1[i], a2[i])) return false;
        }
        return true;
    }
    public static bool ListsEqual<T>(List<T> l1, List<T> l2)
    {
        if (ReferenceEquals(l1, l2))
            return true;

        if (l1 == null || l2 == null)
            return false;

        if (l1.Count != l2.Count)
            return false;

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        for (int i = 0; i < l1.Count; i++)
        {
            if (!comparer.Equals(l1[i], l2[i])) return false;
        }
        return true;
    }
}