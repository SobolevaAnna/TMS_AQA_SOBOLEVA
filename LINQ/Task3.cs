namespace LINQ;

public class Task3
{
    private TestString _testString = new();   
   
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Задание 3");
        
       IEnumerable<string> query = _testString.List.OrderBy(n => n.Length).ThenByDescending(text => text);
                                        
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
    }
}