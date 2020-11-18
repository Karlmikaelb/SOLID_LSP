using System.Collections;
using System.Collections.Generic;

namespace SOLID_DIP
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}