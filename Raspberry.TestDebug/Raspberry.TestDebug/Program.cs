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
            while (true)
            {
                Console.WriteLine("Waiting for VS");
                Thread.Sleep(1000);
            }
#endif
            var tmp = 0;
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
