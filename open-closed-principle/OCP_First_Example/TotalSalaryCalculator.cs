using OCP_First_Example.SalaryCalculators;
using System.Collections.Generic;

namespace OCP_First_Example
{
    public class TotalSalaryCalculator
    {
        private readonly IEnumerable<ISalaryCalculator> _devSalaries;
        public TotalSalaryCalculator(List<ISalaryCalculator> devSalaries)
        {
            _devSalaries = devSalaries;
        }
        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devSalary in _devSalaries)
            {
                totalSalaries += devSalary.CalculateSalary();
            }
            return totalSalaries;
        }
    }
}
