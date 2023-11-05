namespace Xod.Exceptions;

public class DatabaseFileException : Exception
{
    public DatabaseFileException() : base("An error occurred while loading database file. Make sure of the database path or set InitialCreate option.") { }
}