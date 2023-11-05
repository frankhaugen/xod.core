namespace Xod.Exceptions;

public class ReservedKeyWordException : Exception
{
    public ReservedKeyWordException()
        : base("You propably used a reserved keyword as one of the object properties.")
    {
    }
}