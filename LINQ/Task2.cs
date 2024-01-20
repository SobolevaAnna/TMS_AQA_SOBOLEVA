namespace LINQ;

public class Task2
{

    private TestObject _testObject = new TestObject();

    // Основной LINQ ситаксис
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Задание 2");
        
        //последний элемент с минимальной продолжительномтью (Duration)
        var queryResult2 = _testObject.Where(obj => obj.Duration == _testObject.Min(p => p.Duration)).Last();

        Console.WriteLine($"Year: {queryResult2.Year}, NumberMonth: {queryResult2.NumberMonth}, Duration: {queryResult2.Duration}");
    }
}