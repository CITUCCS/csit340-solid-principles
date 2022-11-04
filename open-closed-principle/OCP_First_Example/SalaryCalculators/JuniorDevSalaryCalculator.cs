namespace OCP.SalaryCalculators
{
    internal class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
}
