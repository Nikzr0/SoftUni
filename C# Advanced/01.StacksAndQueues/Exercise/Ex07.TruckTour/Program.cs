using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex07.TruckTour
{
    public class Program
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> petrolToTake = new List<int>();
            List<int> distanceToNextGasStation = new List<int>();

            int gas = 0;

            while (N > 0)
            {
                int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                petrolToTake.Add(commands[0]);
                distanceToNextGasStation.Add(commands[1]);

                N--;
            }
            int firstAnswer = 0;
            int oneEnter = 0;

            int indexPosition = 0;
            foreach (var item in petrolToTake)
            {
                int counter = 0;

                for (int i = indexPosition; i < petrolToTake.Count; i++)
                {
                    gas += petrolToTake[i] - distanceToNextGasStation[i];

                    if (gas >= 0)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter == petrolToTake.Count)
                {
                    break;
                }

                for (int i = 0; i < indexPosition; i++)
                {
                    gas += petrolToTake[i] - distanceToNextGasStation[i];

                    if (gas >= 0)
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                indexPosition++;

                if (counter == petrolToTake.Count)
                {
                    if (oneEnter == 0)
                    {
                        firstAnswer = indexPosition - 1;
                        oneEnter++;
                        break;
                    }
                }
                gas = 0;
            }

            Console.WriteLine(firstAnswer);
        }
    }
}