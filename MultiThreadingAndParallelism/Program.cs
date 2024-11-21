﻿using System;
using System.Threading;

namespace MultiThreadingInCSharp
{
    class Program
    {

        static void ShowNumber(object maxNumber)
        {
            for (int i = 0; i < (int)maxNumber; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {

            //ThreadStart obj = new ThreadStart(ShowNumber);
            //ThreadStart obj = ShowNumber;

            //ThreadStart obj = () => ShowNumber(6);

            ParameterizedThreadStart obj = new ParameterizedThreadStart(ShowNumber);
            Thread t = new Thread(ShowNumber);
            t.Start(10);
            //ShowNumber();


            ////Creating Threads
            //Thread t1 = new(Method1)
            //{
            //    Name = "Thread1"
            //};

            //Thread t2 = new(Method2)
            //{
            //    Name = "Thread2"
            //};

            //Thread t3 = new(Method3)
            //{
            //    Name = "Thread3"
            //};
            ////Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //Console.WriteLine("Main Thread Ended");
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


}
