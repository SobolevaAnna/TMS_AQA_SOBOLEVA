namespace clinic
{
    internal class Surgeon : Doctor
    {
        public Surgeon(string fio, string category) : base(fio, category) { }
        
        public override void Treatment()
        {
            base.Treatment();
            base.Healing();
        }

        public void Treatment(params string[] examx)
        {
            base.Treatment();
            DoEvaluation(examx);
            TreatmentMode();
        }

        public void Treatment(double i, params string[] examx)
        {
            base.Treatment();
            DoEvaluation(examx);
            DateOperation(i);
        }

        private void DoEvaluation(params string[] examx)
        {
            Console.WriteLine("Назначено обследование: ");
            foreach (string exam in examx)
            Console.WriteLine($"{exam}");
        }

        private void DateOperation(double i)
        {
            Console.WriteLine($"Дата операции: {i} январья 2024");
        }

        private void TreatmentMode()
        {
            Console.WriteLine("Назначено медикаментозное лечение");
        }
    }
}
