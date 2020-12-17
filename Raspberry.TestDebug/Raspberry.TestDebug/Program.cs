using System;
using System.Threading;

namespace Raspberry.TestDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App is up");
#if DEBUG
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
#endif
            Console.WriteLine("Please write something");
            string test = Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
