//Console.WriteLine("Hello, World!");

Thread t = Thread.CurrentThread;

t.Name = "Main Thread";
Console.WriteLine("Thread Name" + t.Name);
Console.WriteLine("My cuurent Thread" + Thread.CurrentThread.Name);
Console.ReadLine();


