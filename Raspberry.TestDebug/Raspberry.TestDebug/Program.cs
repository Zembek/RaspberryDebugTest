﻿using System;
using System.Collections.Generic;
using System.Device.Gpio;
using System.Threading;

namespace Raspberry.TestDebug
{
    class Program
    {
        private static List<int> _pinouts = new List<int> { 26, 19, 13, 6, 5, 11 };

        static void Main(string[] args)
        {
            Console.WriteLine("App is up");
#if DEBUG
            Console.WriteLine("Waiting for debugger. Press any key to continue");
            Console.ReadKey();
#endif
            GpioController controller = new GpioController();
            Console.WriteLine("Initialize piouts");
            foreach (var pinNo in _pinouts)
                controller.OpenPin(pinNo, PinMode.Output);
            Console.WriteLine("END Initialize piouts");

            while (true)
            {
                foreach (var pinNo in _pinouts)
                {
                    Console.WriteLine($"Set pin: {pinNo} value: Low");
                    controller.Write(pinNo, PinValue.Low);
                    Console.WriteLine($"Sleep 1500ms");
                    Thread.Sleep(1500);
                    Console.WriteLine($"Set pin: {pinNo} value: High");
                    controller.Write(pinNo, PinValue.High);
                    Console.WriteLine($"Sleep 1000ms");
                    Thread.Sleep(1000);
                }

            }
        }
    }
}
