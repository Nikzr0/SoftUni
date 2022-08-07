using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex07.SoftUniParty
{
    public class Program
    {
        public static void Main()
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            while (true)
            {
                string guestCode = Console.ReadLine();
                if (guestCode == "PARTY")
                {
                    break;
                }

                if (numbers.Contains(guestCode[0]))
                {
                    vipGuests.Add(guestCode);
                }
                else
                {
                    regularGuests.Add(guestCode);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (vipGuests.Contains(command))
                {
                    vipGuests.Remove(command);
                }
                else if (regularGuests.Contains(command))
                {
                    regularGuests.Remove(command);
                }


                if (command == "END")
                {
                    break;
                }
            }

            int guestsWhoDidNotAttend = 0;

            guestsWhoDidNotAttend += vipGuests.Count;
            guestsWhoDidNotAttend += regularGuests.Count;

            Console.WriteLine(guestsWhoDidNotAttend);
            foreach (var item in vipGuests)
            {
                Console.WriteLine(item);
            }

            foreach (var item in regularGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}