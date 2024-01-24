namespace Exceptions;

public class WrongLoginException : Exception
{
    // Конструктор с возможностью передачи сообщения об ошибке
    public WrongLoginException() {}   
    public WrongLoginException(string? message) : base(message) {}
}