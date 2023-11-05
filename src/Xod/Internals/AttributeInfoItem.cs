using System.Reflection;
using Xod.Flags;

namespace Xod.Internals;

internal class AttributeInfoItem
{
    public Type Type { get; set; }
    public string PropertyName { get; set; }
    public PropertyInfo Property { get; set; }
    public dynamic Attribute { get; set; }
    public PropertyTypeCategory TypeCategory { get; set; }
    public System.Type AttributeType { get; set; }
}