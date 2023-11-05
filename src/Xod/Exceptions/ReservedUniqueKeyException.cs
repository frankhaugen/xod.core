namespace Xod.Exceptions;

public class ReservedUniqueKeyException : Exception
{
    public ReservedUniqueKeyException() : base("One or more unique key value is reserved by another object.") { }
}