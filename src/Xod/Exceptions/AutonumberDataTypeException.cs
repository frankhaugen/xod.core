namespace Xod.Exceptions;

public class AutonumberDataTypeException : Exception
{
    public AutonumberDataTypeException() : base("Wrong auto number datatype. This feature can only be applyed on numeric datatype.") { }
}