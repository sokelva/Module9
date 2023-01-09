using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{
    /// <summary>
    /// Делегаты и их прктическое применение
    /// </summary>
    public class Program
    {
        public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);

        static void Main(string[] args)
        {
            Employee empl1 = new Employee()
            {
                ID = 1,
                Name = "Алексей",
                Experience = 5,
                Salary = 20000
            };
            Employee empl2 = new Employee()
            {
                ID = 2,
                Name = "Михаил",
                Experience = 2,
                Salary = 10000
            };
            Employee empl3 = new Employee()
            {
                ID = 3,
                Name = "Сергей",
                Experience = 3,
                Salary = 15000
            };

            List<Employee> ListEmployee = new List<Employee>();
            ListEmployee.Add(empl1);
            ListEmployee.Add(empl2);
            ListEmployee.Add(empl3);

            EligibleToPromotion eligibleToPromotion = Promote;
            Employee.PromoteEmployee(ListEmployee, eligibleToPromotion);
            Console.ReadKey();

        }

        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List <Employee> listEmployee, Program.EligibleToPromotion IsEmployeeEligible)
        {
            foreach (Employee employee in listEmployee)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Сотрудник {0} повышен.", employee.Name);
                }
            }
        }
    }


}
