namespace Xod.Exceptions;

public class IndexDataTypeException : Exception
{
    public IndexDataTypeException() : base("Wrong index datatype. Indices can only be a int, long, string or guid datatype.") { }
}