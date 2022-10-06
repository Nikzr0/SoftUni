using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06.FoodShortage
{
    public interface BD
    {
        public string Birthdate { get; set; }
    }
    public interface IBuyer
    {
        public int Food { get; set; }
        void BuyFood();
    }
    public abstract class Info
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Info()
        {

        }
        public Info(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
    public class Citizen : Info, BD, IBuyer
    {
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }
        public Citizen()
        {

        }
        public Citizen(string name, int age, string id, string birthdate) : base(name, id)
        {
            Age = age;
            Birthdate = birthdate;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
    public class Robot : Info
    {
        public int Food { get; set; }

        public Robot(string name, string id) : base(name, id)
        {
        }
    } // Useless
    public class Pet : BD
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    } // Useless
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }
        public Rebel()
        {

        }
        public Rebel(string name, int age, string group) 
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
    public class Program
    {
        static void Main()
        {
            List<string> buyerInfo = new List<string>();

            Citizen c = new Citizen();
            Rebel r = new Rebel();

            int numbersOfBuyers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfBuyers; i++)
            {
                buyerInfo.Add(Console.ReadLine());
            }

            while (true)
            {
                string buyerName = Console.ReadLine();
                if (buyerName == "End")
                {
                    break;
                }
                
                foreach (var buyer in buyerInfo)
                {
                    string[] bi = buyer.Split(" ");
                    //Citizen c = new Citizen(bi[0], int.Parse(bi[1]), bi[2], bi[3]);
                    //Rebel r = new Rebel(bi[0], int.Parse(bi[1]), bi[2]);

                    if (bi[0] == buyerName)
                    {
                        if (bi.Length == 3)
                        {
                            r.BuyFood();
                        }
                        else if (bi.Length == 4)
                        {
                            c.BuyFood();
                        }
                    }

                }
            }
            Console.WriteLine(r.Food + c.Food);
        }
    }
}