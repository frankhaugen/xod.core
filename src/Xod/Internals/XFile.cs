using System.Xml.Linq;

namespace Xod.Internals;

internal class XFile : IDisposable
{
    string password = null;
    XDocument document = null;

    internal XDocument Document { get { return document; } }

    public string Path { get; private set; }
    public Type Type { get; private set; }

    public XFile(XDocument document, Type type, string path, string password = null)
    {
        this.document = document;
        this.password = password;
        this.Path = path;
    }

    public XElement Root()
    {
        if (document == null)
            return null;

        return document.Root;
    }
    public IEnumerable<XElement> Pages()
    {
        return Get("Pages", "Page");
    }
    public IEnumerable<XElement> Rows()
    {
        return Get("Rows", "Row");
    }

    public string GetFileCode()
    {
        if (!string.IsNullOrEmpty(Path))
            return System.IO.Path.GetFileNameWithoutExtension(Path);
        else
            return null;
    }

    public void Dispose()
    {
        this.document = null;
    }

    private IEnumerable<XElement> Get(string parentName, string childrenName)
    {
        if (document == null)
            return null;

        if (document.Root != null)
        {
            var parentElement = document.Root.Element(parentName);
            if (parentElement != null)
                return parentElement.Elements(childrenName);
        }

        return Enumerable.Empty<XElement>();
    }
}