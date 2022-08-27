using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex08.Threeuple
{
    public class Program
    {
        static void Main()
        {
            //{first name} {last name} {address} {town}
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>();
            // {name} {liters of beer} {drunk or not}
            Threeuple<string, int, string> threeuple2 = new Threeuple<string, int, string>();
            //{name} {account balance} {bank name}
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>();

            List<string> fisrtLineInfo = Console.ReadLine().Split(" ").ToList();

            string firstName = fisrtLineInfo[0];
            fisrtLineInfo.Remove(fisrtLineInfo[0]);
            string secondName = fisrtLineInfo[0];
            fisrtLineInfo.Remove(fisrtLineInfo[0]);
            string street = fisrtLineInfo[0];
            fisrtLineInfo.Remove(fisrtLineInfo[0]);
            string city = string.Join(" ", fisrtLineInfo);

            List<string> seconLineInfo = Console.ReadLine().Split(" ").ToList();

            string name = seconLineInfo[0];
            seconLineInfo.RemoveAt(0);
            int litterOdBeer = int.Parse(seconLineInfo[0]);
            seconLineInfo.RemoveAt(0);
            string drunkOrNot = seconLineInfo[0];

            List<string> thrirdLineInfo = Console.ReadLine().Split(" ").ToList();

            string thirdName = thrirdLineInfo[0];
            thrirdLineInfo.RemoveAt(0);
            double money = double.Parse(thrirdLineInfo[0]);
            thrirdLineInfo.RemoveAt(0);
            string currency = thrirdLineInfo[0];

            Console.WriteLine();
            Console.WriteLine($"{threeuple1.Item1 = firstName + " " + secondName} -> {threeuple1.Item2 = street} -> {threeuple1.Item3 = city}");
            Console.WriteLine($"{threeuple2.Item1 = name} -> {threeuple2.Item2 = litterOdBeer} -> {threeuple2.Item3 = drunkOrNot}");
            Console.WriteLine($"{threeuple3.Item1 = thirdName} -> {threeuple3.Item2 = money} -> {threeuple3.Item3 = currency}");
        }
    }
}