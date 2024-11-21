using System.Diagnostics;
using System.Threading;

namespace MultiThreadingInCSharp;
class Program
{
    static ManualResetEvent _mre = new ManualResetEvent(false);

    static void Main(string[] args)
    {


        Thread t1 = new Thread(Written);

        t1.Start();
        for (int i = 0; i < 5; i++)
        {
            new Thread(Read).Start();
        }

    }


    public static void Written()
    {
        Console.WriteLine("Write Working ");
        _mre.Reset();
        Thread.Sleep(5000);
        Console.WriteLine("Write Completed ");
        _mre.Set();

    }

    public static void Read()
    {
        Console.WriteLine("Read Working Wait ");
        _mre.WaitOne();
        Console.WriteLine("Read Completed ");
        
    }

}


