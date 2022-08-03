using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex11.KeyRevolver
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> queueOfLocks = new Queue<int>();
            Stack<int> stackOfBullets = new Stack<int>();

            int priceOfABullet = int.Parse(Console.ReadLine()); // 50
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int valueOfInteligence = int.Parse(Console.ReadLine());

            foreach (var item in locks)
            {
                queueOfLocks.Enqueue(item);
            }

            foreach (var item in bullets)
            {
                stackOfBullets.Push(item);
            }


            int reloder = sizeOfGunBarrel;

            int operationLength = stackOfBullets.Count;

            for (int i = 0; i < operationLength; i++)
            {

                if (reloder > 0)
                {
                    if (queueOfLocks.Count > 0)
                    {
                        if (stackOfBullets.Pop() <= queueOfLocks.Peek())
                        {
                            queueOfLocks.Dequeue();
                            Console.WriteLine("Bang!");
                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                        }
                        reloder--;
                    }
                }
                else
                {
                    Console.WriteLine("Reloading");
                    operationLength++;
                    reloder = sizeOfGunBarrel;
                }

            }

            if (stackOfBullets.Count >= 0 && queueOfLocks.Count == 0)
            {
                Console.WriteLine($"{stackOfBullets.Count} bullets left. Earned ${valueOfInteligence - (bullets.Length - stackOfBullets.Count) * priceOfABullet}");
            }
            else if (stackOfBullets.Count <= 0 && queueOfLocks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueOfLocks.Count}");
            }

        }
    }
}