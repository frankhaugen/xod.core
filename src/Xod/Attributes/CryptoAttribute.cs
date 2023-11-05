using Xod.Flags;

namespace Xod.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class CryptoAttribute : Attribute
{
    public CryptoMethod Method { get; set; }

    public CryptoAttribute()
    {
        Method = CryptoMethod.MD5;
    }

    public CryptoAttribute(CryptoMethod method)
    {
        Method = method;
    }
}