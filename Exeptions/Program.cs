using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnException
{
    public class Program
    {
        public static string[] ExeptionArray = new string[5] { "OverflowException", "PathTooLongException", "FormatException", "TimeoutException", "MyOwnExeption" };

        static void Main(string[] args)
        {

            foreach (var item in ExeptionArray)
            {
                try
                {
                    throw new Exception(item.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Тип эксепшена: {0}", ex.Message);
                }
                finally
                {
                    CustomException ce = new CustomException("Сообщение базового класса!");
                }
            }
        }
    }

    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            Exception ownException = new Exception("Собственное исключение!");
            Console.WriteLine($"Собственное сообщение: {ownException.Message}");
        }
    }
}
