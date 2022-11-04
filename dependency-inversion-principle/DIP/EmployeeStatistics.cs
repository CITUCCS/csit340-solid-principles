using System.Linq;

namespace DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _empManager;

        public EmployeeStatistics(IEmployeeSearchable employeeManager)
        {
            _empManager = employeeManager;
        }

        public int CountFemaleManagers()
        {
            return _empManager.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }

        public int CountMaleManagers()
        {
            return _empManager.GetEmployeesByGenderAndPosition(Gender.Male, Position.Manager).Count();
        }

        public int CountFemaleAdministors()
        {
            return _empManager.GetEmployeesByGenderAndPosition(Gender.Female, Position.Administrator).Count();
        }
    }
}
