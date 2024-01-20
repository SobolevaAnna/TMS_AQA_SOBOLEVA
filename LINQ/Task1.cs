    namespace LINQ;

public class Task1
{
    List<int> numbers = new List<int> { 1, 3, 3, 3, 4, 4, 5 };
    
    public void RunMethodSyntax1()
    {
        // Method Syntax
        Console.WriteLine("Задание 1");
  
        var methodResult = numbers.Where(num => num % 2 != 0).Select(number => number).Distinct();

        foreach (var i in methodResult)
        {
            Console.WriteLine($"{i}");
        }

    }
}