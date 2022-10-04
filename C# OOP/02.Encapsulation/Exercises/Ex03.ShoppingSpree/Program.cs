using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<string> BagOfProducts { get; set; }
        public Person()
        {
            BagOfProducts = new List<string>();
        }
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            List<string> lineOfPeople = Console.ReadLine().Split(";").ToList();
            foreach (var item in lineOfPeople)
            {
                string[] info = item.Split("=");
                try
                {
                    people.Add(new Person(info[0], double.Parse(info[1])));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            List<string> lineOfProducts = Console.ReadLine().Split(";").ToList();
            foreach (var item in lineOfProducts)
            {
                if (item != "")
                {
                    string[] info = item.Split("=");
                    products.Add(new Product(info[0], double.Parse(info[1])));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] action = input.Split(" ");

                foreach (var item in people.Where(x => x.Name == action[0]))
                {
                    string productName = action[1];
                    double productCost = 0;

                    foreach (var product in products.Where(x => x.Name == action[1]))
                    {
                        productCost = product.Cost;
                    }

                    if (item.Money >= productCost)
                    {
                        item.Money -= productCost;

                        item.BagOfProducts.Add(productName);
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} can't afford {productName}");
                    }
                }
            }

            foreach (var item in people)
            {
                if (item.BagOfProducts != null)
                {
                    string allProducts = string.Join(", ", item.BagOfProducts);
                    Console.WriteLine($"{item.Name} - {allProducts}");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
            }
        }
    }
}