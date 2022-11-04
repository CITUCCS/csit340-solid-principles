namespace OCP.SalaryCalculators
{
    internal abstract class BaseSalaryCalculator : ISalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }
        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
