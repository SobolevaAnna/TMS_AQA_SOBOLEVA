using Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Введите логин: ");
            string? login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string? password = Console.ReadLine();

            Console.Write("Введите пароль повторно: ");
            string? confirmPassword = Console.ReadLine();

            try
            {

            if (Task1.Registration(login, password, confirmPassword))
                Console.WriteLine("Вы успешно вошли в систему");
            }

            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

