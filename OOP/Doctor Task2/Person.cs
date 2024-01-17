namespace clinic
{
    internal class Person
    {
        public string FIO { get; set; } = "Не определено";
        public Person(string fio) => FIO = fio;
    }
}