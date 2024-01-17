namespace clinic
{
    internal class Doctor : Person
    {
        public string Category { get; set; } = "Не определено";
        public Doctor(string fio, string category) : base(fio) => Category = category;
        public virtual void Treatment() => MethodTreatment();

        private void MethodTreatment()
        {
            Console.WriteLine("Метод лечения: ");
        }
        public virtual void Healing() => Heal();

        private void Heal()
        {
            Console.WriteLine("Пациент здоров");
        }
    }
}