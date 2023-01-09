using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class Program
    {

        public delegate int DelegateSum(int a, int b);

        static void Main(string[] args)
        {
            DelegateSum delegateSum = Sum.SumMethod;
            int result = delegateSum(5, 6);
            Console.WriteLine($"{result}");

            int result2 = delegateSum.Invoke(5, 6);
            Console.WriteLine($"{result2}");

            DelegateSum delegateSum2 = (a, b) =>
            {
                int returnValue = a - b;
                return returnValue;

            };
            Console.WriteLine($"{delegateSum2.Invoke(5, 6)}");
            Console.ReadKey();
        }
    }

    public class Sum
    {
        public static int SumMethod(int a, int b)
        {
            int returnValue = a - b;
            return returnValue;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

    }
}
