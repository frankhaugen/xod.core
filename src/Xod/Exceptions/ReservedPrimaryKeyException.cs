namespace Xod.Exceptions;

public class ReservedPrimaryKeyException : Exception
{
    public ReservedPrimaryKeyException() : base("The primary key value is reserved by another object.") { }
}