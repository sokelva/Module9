using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatePractice
{
    public class Program
    {

        public delegate void Sort(List<Employee> employees, int flag);
        public static event Sort SetSortFlag; // событие

        static void Main(string[] args)
        {

            Employee empl1 = new Employee()
            {
                Name = "Алексей",
                LastName  = "Иванов"
            };

            Employee empl2 = new Employee()
            {
                Name = "Иван",
                LastName = "Афонин"
            };

            Employee empl3 = new Employee()
            {
                Name = "Михаил",
                LastName = "Муромов"
            };

            Employee empl4 = new Employee()
            {
                Name = "Дмитрий",
                LastName = "Ткаченко"
            };

            Employee empl5 = new Employee()
            {
                Name = "Степан",
                LastName = "Химов"
            };

            List<Employee> lst = new List<Employee>();
            lst.Add(empl1);
            lst.Add(empl2);
            lst.Add(empl3);
            lst.Add(empl4);
            lst.Add(empl5);

            SetSortFlag += EmployeeSort;
            SetSortFlag?.Invoke(lst, 2); //<-- ЗДЕСЬ МЕНЯЕМ ФЛАГ СОРТИРОВКИ. 

        }

        public static void EmployeeSort(List<Employee> listemployee, int sortFlag)
        {
            IOrderedEnumerable<Employee> l;
            try
            {
                if (sortFlag == 1)
                {
                    l = listemployee.OrderBy(p => p.LastName);
                    Console.WriteLine($"Сортировка списка Employee от А-Я:\n----------------------------------");
                    ShowEmployeesList(l);
                }
                else
                {
                    l = listemployee.OrderByDescending(p => p.LastName);
                    Console.WriteLine($"Сортировка списка Employee от Я-А:\n----------------------------------");
                    ShowEmployeesList(l);
                }
            }
            catch (Exception ex)
            {
                CustomException exc = new CustomException($"{ex.Message}");
            }
            Console.ReadKey();
        }

        public static void ShowEmployeesList(IOrderedEnumerable<Employee> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine($"{item.LastName} {item.Name}");
            }
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Employee()
        {

        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            Exception ownException = new Exception("Собственное исключение!");
            Console.WriteLine($"Собственное сообщение: {ownException.Message}");
            Console.ReadKey();
        }
    }
}
