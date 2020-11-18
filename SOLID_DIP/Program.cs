using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Kalle", Gender = Gender.Male, Position = Position.Administrator });
            empManager.AddEmployee(new Employee { Name = "Bella", Gender = Gender.Female, Position = Position.Manager });

            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Antalet kvinnliga managers på vårat företag är: {stats.CountFemaleManagers()}");
            Console.ReadLine();
        }
    }
}
