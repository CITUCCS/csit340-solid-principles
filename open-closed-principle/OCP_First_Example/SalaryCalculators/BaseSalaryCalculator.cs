using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_First_Example.SalaryCalculators
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
