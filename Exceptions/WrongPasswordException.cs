namespace Exceptions;

public class WrongPasswordException : Exception
{
    // Конструктор с возможностью передачи сообщения об ошибке
    public WrongPasswordException() {}   
    public WrongPasswordException(string? message) : base(message) {}
}