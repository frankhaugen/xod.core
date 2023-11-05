namespace Xod.Exceptions;

public class MissingParentKeyException : Exception
{
    public MissingParentKeyException() : base("Parent property is missing in child reference type.") { }
}