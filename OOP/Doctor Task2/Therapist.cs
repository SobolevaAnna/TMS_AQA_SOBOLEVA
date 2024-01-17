namespace clinic
{

    internal class Therapist : Doctor
    {
        public Therapist(string fio, string category) : base(fio, category) { }
        
        public override void Treatment()
        {
            base.Treatment();
            base.Healing();
        }

        public void Treatment(params string[] pills)
        {
            base.Treatment();
            TreatmentMode(pills);
        }

        public void Treatment(string i)
        {
            base.Treatment();
            WriteReferral(i);
        }

 
        private void WriteReferral(string i)
        {
            Console.WriteLine($"Выписано направление к {i}");
        }
        
        private void TreatmentMode(params string[] pills)
        {
            Console.WriteLine("Выписаны лекарства: ");
            foreach (string pill in pills)
                Console.WriteLine($"{pill}");
            Console.WriteLine();
        }

    }
}