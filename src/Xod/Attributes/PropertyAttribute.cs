using Xod.Flags;

namespace Xod.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class PropertyAttribute : Attribute
{
    public ValuePosition Position { get; set; }
    public CascadeOptions Cascade { get; set; }
    public bool AutoNumber { get; set; }
    public bool Indexed { get; set; }

    public PropertyAttribute()
    {
        Position = ValuePosition.Body;
        Cascade = CascadeOptions.None;
        IdentitySeed = 1;
        IdentityIncrement = 1;
        //OverrideAutoNumber = true;
    }

    public dynamic IdentitySeed { get; set; }
    public dynamic IdentityIncrement { get; set; }
}