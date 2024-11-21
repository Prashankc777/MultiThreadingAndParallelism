using System.Diagnostics;
using System.Threading;

namespace MultiThreadingInCSharp;
class Program
{
    static Semaphore _event = new Semaphore(2,2);

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Written);
        t1.Start();
        for (int i = 0; i < 5; i++)
        {
            new Thread(Written).Start();
        }
        Thread.Sleep(4000);
        _event.Release();
        Console.ReadLine();

    }

    public static void Written()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Waiting ");
        _event.WaitOne();
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Working ");
        Thread.Sleep(5000);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "Write Complete");
        _event.Release();
    }
    
}


