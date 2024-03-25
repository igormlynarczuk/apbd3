namespace ConsoleApp1.Exceptions;

public class OverFillException : Exception
{
    public OverFillException(string message) : base(message)
    {
    }
}