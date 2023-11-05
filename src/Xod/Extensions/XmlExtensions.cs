namespace Xod.Extensions;

public static class XmlExtensions
{
    public static bool ElementAttributesEquals(this System.Xml.Linq.XElement a, System.Xml.Linq.XElement b)
    {
        if (a.HasAttributes != b.HasAttributes)
            return false;

        foreach (System.Xml.Linq.XAttribute at in a.Attributes())
        {
            if (b.Attribute(at.Name) == null || !at.Value.Equals(b.Attribute(at.Name).Value))
                return false;
        }

        return true;
    }

    public static bool ElementEquals(this System.Xml.Linq.XElement a, System.Xml.Linq.XElement b)
    {
        if (!a.Name.LocalName.Equals(b.Name.LocalName))
            return false;

        if (!a.ElementAttributesEquals(b))
            return false;

        if ((!a.HasElements && !b.HasElements) && !a.Value.Equals(b.Value))
            return false;

        if (a.HasElements != b.HasElements)
            return false;

        if (a.HasElements == b.HasElements == true && a.Elements().Count() != b.Elements().Count())
            return false;

        if (a.Attribute("refType") == null || a.Attribute("refType").Value != "children")
        {
            foreach (var ae in a.Elements())
            {
                var be = b.Elements().Where(s => ae.ElementEquals(s));
                if (!be.Any())
                    return false;
            }
        }
        else
        {
            return false;
        }

        return true;
    }

    public static bool ElementMatch(this System.Xml.Linq.XElement a, System.Xml.Linq.XElement b)
    {
        if (!a.Name.LocalName.Equals(b.Name.LocalName))
            return false;

        if (a.HasElements != b.HasElements)
            return false;

        if (!a.HasElements && !b.HasElements && !a.Value.Equals(b.Value, StringComparison.CurrentCultureIgnoreCase))
            return false;

        foreach (System.Xml.Linq.XAttribute at in a.Attributes())
        {
            if (b.Attribute(at.Name) == null || !at.Value.Equals(b.Attribute(at.Name).Value, StringComparison.CurrentCultureIgnoreCase))
                return false;
        }

        if (a.HasElements == b.HasElements == true && a.Elements().Count() > b.Elements().Count())
            return false;

        foreach (var ae in a.Elements())
        {
            var be = b.Elements().Where(s => ae.ElementMatch(s));
            if (!be.Any())
                return false;
        }

        return true;
    }
}