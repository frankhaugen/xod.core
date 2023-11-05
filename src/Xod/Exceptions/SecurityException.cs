namespace Xod.Exceptions;

public class SecurityException : Exception
{
    public SecurityException() : base("Unable to open database file, you need a valid password.") { }
    public SecurityException(string message) : base(message) { }
}