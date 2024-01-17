namespace clinic;

internal class Patient : Person
{
    public TreatmentPlan PatientTreatmentPlan { get; set; } = new TreatmentPlan(0);

    public Patient(string fio, TreatmentPlan patientTreatmentPlan) : base(fio) => PatientTreatmentPlan = patientTreatmentPlan;

        public void AppointDoctor()
        {
            switch (PatientTreatmentPlan.TreatmentPlanCode)
            {
                case 1:
                    Surgeon surgeon = new Surgeon("Цымбалов О.В.", "Врач высшей категории");
                    Console.WriteLine($"\nЛечение проводит хирург {surgeon.FIO}, {surgeon.Category}");
                    surgeon.Treatment(24, "рентген");
                    break;

                case 2:
                    Dantist dantist = new Dantist("Стефанов И.Е.", "Врач высшей категории");
                    Console.WriteLine($"\nЛечение проводит дантист {dantist.FIO}, {dantist.Category}");
                    dantist.Treatment(true);
                    break;

                default:
                    Therapist therapist = new Therapist("Разумовский С.С.", "Врач первой категории");
                    Console.WriteLine($"\nЛечение проводит терапевт {therapist.FIO}, {therapist.Category}");
                    therapist.Treatment("индовазин", "апизатрон");
                    break;
            }
        }
}   