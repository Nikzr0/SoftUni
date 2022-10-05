using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.Telephony
{
    public interface ICall
    {
        void Calling(string phonenumber);
    }

    public interface IBrowsing
    {
        void Brows(string URL);
    }

    public class Smartphone : ICall, IBrowsing
    {
        public void Calling(string phoneNumber)
        {
            Console.WriteLine($"Calling... {phoneNumber}");
        }
        public void Brows(string URL)
        {
            bool noDigits = URL.Any(char.IsDigit);
            if (noDigits)
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {URL}");
            }
        }
    }

    public class Stationaryphone : ICall
    {
        public void Calling(string phoneNumber)
        {
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
    public class Program
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] urls = Console.ReadLine().Split(" ");

            Smartphone smartp = new Smartphone();
            Stationaryphone statp = new Stationaryphone();

            Console.WriteLine();
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (phoneNumbers[i].Length == 10)
                {
                    smartp.Calling(phoneNumbers[i]);
                }
                else
                {
                    statp.Calling(phoneNumbers[i]);
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                smartp.Brows(urls[i]);
            }
        }
    }
}