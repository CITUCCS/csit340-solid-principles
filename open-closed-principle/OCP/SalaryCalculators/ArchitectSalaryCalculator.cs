namespace OCP.SalaryCalculators
{
    internal class ArchitectSalaryCalculator : BaseSalaryCalculator
    {
        public ArchitectSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.5;
    }
}
