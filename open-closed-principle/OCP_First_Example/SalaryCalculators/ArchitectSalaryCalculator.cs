using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_First_Example.SalaryCalculators
{
    internal class ArchitectSalaryCalculator : BaseSalaryCalculator
    {
        public ArchitectSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.5;
    }
}
