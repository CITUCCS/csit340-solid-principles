using OCP;
using OCP.SalaryCalculators;
using System;
using System.Collections.Generic;

var devSalaries = new List<ISalaryCalculator>
{
    new SeniorDevSalaryCalculator(new DeveloperReport
    {
        Id = 1,
        Name = "Dev1",
        Level = "Senior developer",
        HourlyRate  = 30.5,
        WorkingHours = 160
    }),
    new JuniorDevSalaryCalculator(new DeveloperReport
    {
        Id = 2,
        Name = "Dev2",
        Level = "Junior developer",
        HourlyRate  = 20,
        WorkingHours = 150
    }),
    new SeniorDevSalaryCalculator(new DeveloperReport
    {
        Id = 3,
        Name = "Dev3",
        Level = "Senior developer",
        HourlyRate  = 30.5,
        WorkingHours = 180
    }),
    new ArchitectSalaryCalculator(new DeveloperReport
    {
        Id = 4,
        Name = "Arch1",
        Level = "Architect",
        HourlyRate  = 50.5,
        WorkingHours = 180
    })
};

var calculator = new TotalSalaryCalculator(devSalaries);
Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
