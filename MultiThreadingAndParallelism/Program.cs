using System.Diagnostics;

namespace MultiThreadingInCSharp;
class Program
{
    public static int sum = 0;

    static void Main(string[] args)
    {
        Stopwatch _watch = Stopwatch.StartNew();
        Thread t1 = new Thread(Addition);
        Thread t2 = new Thread(Addition);
        Thread t3 = new Thread(Addition);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Total Sum is " + sum);
        _watch.Stop();
        Console.WriteLine("Time taken is " + _watch.ElapsedTicks);
        Console.ReadLine();
    }


    //public static object _lock = new object();

    public static void Addition()
    {
        for (int i = 0; i < 50000; i++)
        {
            // sum++;
             Interlocked.Increment(ref sum); // for perfomance this is better 

            //lock (_lock)
            //{
            //    sum++;
            //}

        }
    }


}


