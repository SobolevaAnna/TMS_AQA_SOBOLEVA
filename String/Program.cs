using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        //Задание 1.
        Console.WriteLine("\n--------------------------------------------------------------------------------");
        Console.WriteLine(@"Задание 1. 
Заменить в строке все вхождения 'test' на 'testing'. 
Удалить из текста все символы, являющиеся цифрами.");
        Console.WriteLine("--------------------------------------------------------------------------------\n");

        string str1 = "test20age4testariadna";
        Console.WriteLine($"Исходная строка: {str1}");
        string result = str1.Replace("test", "testing");
        result = Regex.Replace(result, "[0-9]", "");
        Console.WriteLine($"Результат: {result}");

        //Задание 2.
        Console.WriteLine("\n--------------------------------------------------------------------------------");
        Console.WriteLine(@"Задание 2. 
Выведите на экран следующую фразу: Welcome to the TMS lessons.
Каждое слово должно быть записано отдельно и взято в кавычки.");
        Console.WriteLine("--------------------------------------------------------------------------------\n");

        string[] str2 = { "Welcome", "to", "the", "TMS", "lessons." };
        string strresult = string.Join(@""" """, str2);
        strresult = string.Concat(@"""", strresult, @"""");
        Console.WriteLine(strresult);

        //Задание 3.
        Console.WriteLine("\n--------------------------------------------------------------------------------");
        Console.WriteLine(@"Задание 3. 
Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter. 
Записать всё что до ""abc"" в первую переменную, всё, что после - во вторую.");
        Console.WriteLine("--------------------------------------------------------------------------------\n");

        string str3 = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        string[] abc = str3.Split("abc");
        string beforeabc = abc[0];
        string afterabc = abc[1];
        Console.WriteLine(@$"Строка до символов ""abc"": {beforeabc} 
Строка после символов ""abc"": {afterabc}");

        //Задание 4.
        Console.WriteLine("\n--------------------------------------------------------------------------------");
        Console.WriteLine(@"Задание 4. 
Удалить слово ""плохой""
Создать строку со значением: Хороший день!!!!!!!!! 
Заменить последний ""!"" на ""?"".");
        Console.WriteLine("--------------------------------------------------------------------------------\n");

        string badday = "Плохой день.";
        string day = badday.Substring(7);
        string goodday = day.Insert(0, "Хороший").Replace(".", "!!!!!!!!!");
        goodday = goodday.Remove(goodday.LastIndexOf('!')).Insert(goodday.Length - 1, "?");
        Console.WriteLine(goodday);
    }
}