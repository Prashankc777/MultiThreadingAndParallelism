using System;
using System.Threading;

namespace MultiThreadingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method execution started");

            Thread t1 = new Thread(Program.Method1);
            t1.Start();
            Thread t2 = new Thread(Program.Method2);
            t2.Start();

            if(t1.Join(2000))
            {
                Console.WriteLine("Method 1 execution Completed");
            }
            
            t2.Join();
            Console.WriteLine("Method 2 execution Completed");

            Console.WriteLine(t1.IsAlive
                ? "Method 1 execution is still going on "
                : "Method 1 execution is Completed ");

            Console.WriteLine("Main method execution completed");
            Console.ReadLine();
        }

        static void Method1()
        {
            Console.WriteLine("Method1 execution started");
            Thread.Sleep(5000);
            Console.WriteLine("method 1 is awake");
        }

        static void Method2()
        {
            Console.WriteLine("Method2 execution started");
        }
    }


}