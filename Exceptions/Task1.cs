using System.Text.RegularExpressions;

namespace Exceptions;

public static class Task1
{
    public static bool Registration(string? login, string? password, string? confirmPassword)
    {
        bool flag = true;

        if (login.Length >= 20)
        {
            flag = false;
            throw new WrongLoginException("Длина логина должна быть меньше 20 символов");
        }

        if (string.IsNullOrWhiteSpace(login))
        {
            flag = false;
            throw new WrongLoginException("Логин не может быть пустой строкой");
        }

        if (login.Contains(" "))
        {
            flag = false;
            throw new WrongLoginException("Логин не может содержать пробелы");
        }

        if (password.Length >= 20)
        {
            flag = false;
            throw new WrongPasswordException("Длина пароля должна быть меньше 20 символов");
        }
        
        if (string.IsNullOrWhiteSpace(password))
        {
            flag = false;
            throw new WrongPasswordException("Пароль не может быть пустой строкой");
        }

        if (password.Contains(" "))
        {
            flag = false;
            throw new WrongPasswordException("Пароль не может содержать пробелы");
        }

        if (!password.Any(char.IsDigit))
        {
            flag = false;
            throw new WrongPasswordException("Пароль должен содержать хотя бы одну цифру");
        }

        if (password != confirmPassword)
        {
            flag = false;
            throw new WrongPasswordException("Пароль не совпадает с подтверждением пароля");
        }

        return flag;
    }
}

