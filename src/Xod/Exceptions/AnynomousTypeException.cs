namespace Xod.Exceptions;

public class AnynomousTypeException : Exception
{
    public AnynomousTypeException() : base("Anynomous type properties should be registered by using RegisterType<>() function right after initializing the database.") { }
}