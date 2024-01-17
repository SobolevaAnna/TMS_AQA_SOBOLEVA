namespace clinic
{
        internal class TreatmentPlan
    {
        public int TreatmentPlanCode { get; set; } = 0;

        public TreatmentPlan(int treatmentPlanCode) => TreatmentPlanCode = treatmentPlanCode;
        
    }
}