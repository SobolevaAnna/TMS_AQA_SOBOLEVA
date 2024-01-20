namespace LINQ;

public class Task4
{
    public record ListEmployees(string Lasttname, string Specialty);

    public List<ListEmployees> listEmployees = new List<ListEmployees>()
    {
        new ListEmployees("Матвеева В.И.", "Architector"),
        new ListEmployees("Алексеев А.А.", "System Analyst"),
        new ListEmployees("Зайцев М.Г.", "System Analyst"),
        new ListEmployees("Соколова Д.Д.", "QA"),
        new ListEmployees("Краснова К.А", "QA"),
        new ListEmployees("Малахова М.В.", "QA")
    };

    public record SalaryStatement(string Lasttname, int Salary);

    public List<SalaryStatement> salaryStatement = new List<SalaryStatement>()
    {
        new SalaryStatement("Матвеева В.И.", 100000),
        new SalaryStatement("Алексеев А.А.", 95000),
        new SalaryStatement("Зайцев М.Г.", 75000),
        new SalaryStatement("Соколова Д.Д.", 80000),
        new SalaryStatement("Краснова К.А", 80000),
       new SalaryStatement ("Малахова М.В.", 80000)
    };

    public void RunMethodSyntax()
    {
        Console.WriteLine("Задание 4");

        var queryResult = listEmployees
        .Join(salaryStatement, 
        person => person.Lasttname, 
        person1 => person1.Lasttname, 
        (listEmployees, salaryStatement) => new {listEmployees.Lasttname, listEmployees.Specialty, salaryStatement.Salary})
        .GroupBy(person => person.Specialty)
        .Select(result => new { GroupName = result.Key, Sum = result.Sum(x => x.Salary) });

        foreach (var i in queryResult)
        {
            Console.WriteLine($"{i}");
        }
    }
}