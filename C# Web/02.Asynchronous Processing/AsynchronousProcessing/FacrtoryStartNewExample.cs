using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProcessing
{
    public class FacrtoryStartNewExample
    {
        static int counter = 0;
        // Common way to ensure that counter++ below is not accessed by more than one thread at the time!
        static object lockObject = new object();

        // NOTE!
        //In the example below, I use the lock statement to exercise the use of multithreaded
        //programming without causing problems in the end result and keeping the performance high.
        //However, there is a better way to do so, by using Interlocked and ConcurrentBag.
        //Using lock is simple and I prefer it, in this example, but there is surely a bette way to achive the same result.

        static void LockExaple()
        {
            var tasks = new Task[8];

            for (int i = 0; i < 8; i++)
            {
                // Factory.StartNew is simular to Task.Run() but with more options
                tasks[i] = Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 100_000; j++)
                    {
                        // Use lock to synchronize access to shared counter variable
                        lock (lockObject)
                        {
                            counter++;
                        }
                    }
                });
            }

            // As the name says Task.WaitAll waits all tasks to finish their
            // job bofore printion the result on the console.
            Task.WaitAll(tasks);

            Console.WriteLine($"Counter value: {counter}. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
