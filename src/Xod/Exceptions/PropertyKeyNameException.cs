namespace Xod.Exceptions;

public class PropertyKeyNameException : Exception
{
    public PropertyKeyNameException()
        : base("Wrong propery name in ForeignKey or ParentKey attribute.")
    {
    }
}