using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.ParkingLot
{
    public class Program
    {
        public static void Main()
        {
            HashSet<string> carNumber = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(", ");
                string direction = command[0];
                string carNum = command[1];

                if (direction == "IN")
                {
                    carNumber.Add(carNum);
                }
                else if (direction == "OUT")
                {
                    carNumber.Remove(carNum);
                }
            }

            if (carNumber.Count > 0)
            {
                foreach (var item in carNumber)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}