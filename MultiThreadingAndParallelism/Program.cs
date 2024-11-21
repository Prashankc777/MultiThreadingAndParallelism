using System;
using System.Threading;

namespace MultiThreadingInCSharp
{
    class Program
    {

       
        static void Main(string[] args)
        {

            int max = 10;
            NumberHelper numberHelper = new NumberHelper(10);
            ThreadStart obj = new ThreadStart(numberHelper.ShowNumber);

            Thread t1 = new Thread(obj);
            t1.Start();
            Console.ReadLine();
        }

        //static void Method1()
        //{

        //    Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method1 :" + i);
        //    }
        //    Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        //}

        //static void Method2()
        //{
        //    Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method2 :" + i);
        //        if (i == 2)
        //        {
        //            Console.WriteLine("Method2 DB operation Started");
        //            //Sleep for 10 seconds
        //            Thread.Sleep(10000);
        //            Console.WriteLine("Method2 DB operation Completed");
        //        }
        //    }
        //    Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
        //}

        //static void Method3()
        //{
        //    Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method3 :" + i);
        //    }
        //    Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        //}
    }


    public class NumberHelper
    {
        private int _Number;

        public NumberHelper(int num)
        {
            _Number = num;
        }

        public void ShowNumber()
        {
            for (int i = 0; i < _Number; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

}
