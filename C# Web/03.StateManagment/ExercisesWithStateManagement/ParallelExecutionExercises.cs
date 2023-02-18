using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWithStateManagement
{
    public class ParallelExecutionExercises
    {
        static int count;
        static object lockObject = new object();
        //Should be renamed before execution
        static void RenameToMainBeforeExecution()
        {
            Stopwatch sw = Stopwatch.StartNew();

            Console.WriteLine(count);
            PrintPrime(0, 10_000_000);
            Console.WriteLine(count);
            Console.WriteLine(sw.Elapsed);
        }

        static void PrintPrime(int min, int max)
        {
            Parallel.For(min, max + 1, i =>
            {
                bool isPrime = true; 
                for (int J = 2; J < Math.Sqrt(i); J++)
                {
                    if (i % J == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    lock (lockObject)
                    {
                        count++;
                    }
                }
            });
        }
    }
}
