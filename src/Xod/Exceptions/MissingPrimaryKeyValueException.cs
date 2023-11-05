namespace Xod.Exceptions;

public class MissingPrimaryKeyValueException : Exception
{
    public MissingPrimaryKeyValueException() : base("The object you are trying to persist is lacking a primary key property.") { }
}