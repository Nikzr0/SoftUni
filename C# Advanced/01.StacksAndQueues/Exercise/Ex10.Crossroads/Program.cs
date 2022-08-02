using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex10.Crossroads
{
    public class Program
    {
        public static void Main()
        {
            int greenLightInSeconda = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            int savePassesCounter = 0;

            List<string> listOdCrashes = new List<string>();

            
            while (true)
            {
                int greenLightDuration = greenLightInSeconda;
                string nameOfCar = Console.ReadLine();

                if (nameOfCar == "END")
                {
                    break;
                }

                if (nameOfCar.ToLower() == "green")
                {
                    int howMuchToRemove = 0;
                    foreach (var item in queueOfCars)
                    {
                        if (greenLightDuration > 0)
                        {
                            if (greenLightDuration + freeWindow - item.Length >= 0)
                            {
                                greenLightDuration -= item.Length;
                                howMuchToRemove++;
                            }
                            else
                            {
                                int whereWasHit = item.Length;

                                whereWasHit -= greenLightDuration;
                                whereWasHit -= freeWindow;

                                string theNameOfTheCar = item;

                                string hitLetter = theNameOfTheCar[item.Length - whereWasHit].ToString();

                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{item} was hit at {hitLetter}.");
                                System.Environment.Exit(1);
                            }
                            savePassesCounter++;
                        }
                    }

                    if (howMuchToRemove > 0)
                    {
                        for (int i = 0; i < howMuchToRemove; i++)
                        {
                            queueOfCars.Dequeue();
                        }
                    }

                    howMuchToRemove = 0;
                }
                else
                {
                    queueOfCars.Enqueue(nameOfCar);
                }


            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{savePassesCounter} total cars passed the crossroads.");
        }
    }
}