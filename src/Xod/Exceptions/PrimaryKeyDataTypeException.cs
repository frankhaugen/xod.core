namespace Xod.Exceptions;

public class PrimaryKeyDataTypeException : Exception
{
    public PrimaryKeyDataTypeException() : base("Wrong primary key datatype. Primary key can only be a primitive datatype, string or enum.") { }
}