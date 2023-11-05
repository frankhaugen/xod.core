namespace Xod.Exceptions;

public class ReservedChildException : Exception
{
    public ReservedChildException() : base("This child object is reserved by another parent object.") { }
}