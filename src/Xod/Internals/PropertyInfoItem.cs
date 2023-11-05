using System.Reflection;
using Xod.Attributes;
using Xod.Flags;

namespace Xod.Internals;

internal class PropertyInfoItem
{
    public Type Type { get; set; }

    public string PropertyName { get; set; }
    public Type PropertyType { get; set; }
    public PropertyInfo Property { get; set; }


    public PropertyTypeCategory TypeCategory { get; set; }
    public PropertyReferenceType ReferenceType { get; set; }
    public CascadeOptions Cascade { get; set; }
    public string ChildParentProperty { get; set; }
    public Type CollectionItemType { get; set; }

    public bool IsGenericType { get; set; }
    public string GenericTypeProperty { get; set; }

    public List<ForeignKeyAttribute> ForeignKeys { get; set; }
    public List<ParentKeyAttribute> ParentKeys { get; set; }

    public string RelationshipName { get; set; }

    public bool IsPrimaryKey { get; set; }
    public bool IsRequired { get; set; }
    public bool IsUnique { get; set; }
    public bool IsNotMapped { get; set; }
    public bool IsMarkup { get; set; }
    public bool IsReadOnly { get; set; }
    public bool IsInherited { get; set; }
    public bool IsIndexed { get; set; }

    public bool IsAutonumber { get; set; }
    public dynamic IdentityIncrement { get; set; }
    public dynamic IdentitySeed { get; set; }

    public ValuePosition ValuePosition { get; set; }
    public dynamic DefaultValue { get; set; }

    public CryptoMethod Encryption { get; set; }

    public PropertyInfoItem()
    {
        this.IdentitySeed = 1;
        this.IdentityIncrement = 1;
    }
}