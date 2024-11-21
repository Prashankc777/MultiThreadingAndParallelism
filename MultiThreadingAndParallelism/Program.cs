using System;
using System.Net.WebSockets;
using System.Threading;

namespace MultiThreadingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            //Console.WriteLine("Thread name - " + t.Name);
            //Console.WriteLine("My current thread - " + Thread.CurrentThread.Name);
            Method1();
            Console.WriteLine("Method 1 exection Completed");
            Method2();
            Console.WriteLine("Method 2 Exection Completed");
            Method3();
            Console.WriteLine("Method 3 execution Complteed");
            Console.ReadLine();
        }


        private static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }

        private static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 2)
                {
                    Console.WriteLine("Execution Code Started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Executing Completed");
                }

            }
        }

        private static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }
    }


}