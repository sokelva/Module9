using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Использование делегатов
/// </summary>
namespace DelegatePractices0
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }

        static void ShowMessage(string _message)
        {
            Console.WriteLine(_message);
        }
    }
}

/// <summary>
/// Использование анонимных методов
/// </summary>
namespace DelegatePractices1
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}


/// <summary>
/// Использование лядмбда-выражений
/// </summary>
namespace DelegatePractices2
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = (string _message) => //лядмбда - выражение
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }
    }
}


