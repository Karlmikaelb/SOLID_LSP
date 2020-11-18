using System.Linq;

namespace SOLID_DIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _employee;

        public EmployeeStatistics(IEmployeeSearchable employee)
        {
            _employee = employee;
        }

        public int CountFemaleManagers()
        {
            return _employee.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }

        public int CountMaleAdministrators()
        {
            return _employee.GetEmployeesByGenderAndPosition(Gender.Male, Position.Administrator).Count();
        }
    }
}