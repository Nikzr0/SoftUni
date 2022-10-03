using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        //private List<Product> bagOfProducts;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty");
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
                    throw new ArgumentNullException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<string> BagOfProducts { get; set; }
        public Person()
        {
            List<string> BagOfProducts = new List<string>();
        }
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
    }

    public class Product
    {
        //private string name;
        //private decimal cost;

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
                people.Add(new Person(info[0], double.Parse(info[1])));
            }

            List<string> lineOfProducts = Console.ReadLine().Split(";").ToList();
            foreach (var item in lineOfProducts)
            {
                string[] info = item.Split("=");
                products.Add(new Product(info[0], double.Parse(info[1])));
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] action = input.Split(" ");

                foreach (var item in people.Where(x=>x.Name == action[0]))
                {
                    string nameOfProduct = "";
                    double priceOfProduct = 0;

                    foreach (var product in products.Where(x=>x.Name == action[1]))
                    {
                        product.Name = nameOfProduct;
                        product.Cost = priceOfProduct;
                    }

                    if (item.Money >= priceOfProduct)
                    {
                        item.Money -= priceOfProduct;
                        item.BagOfProducts.Add(action[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} can't afford {nameOfProduct}");
                    }
                }
            }

            foreach (var item in people)
            {
                if (item.BagOfProducts != null)
                {
                    foreach (var prods in item.BagOfProducts)
                    {
                        string allProducts = string.Join(", ", prods);
                        Console.WriteLine($"{item.Name} - {allProducts}");
                    }
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }               
            }
        }
    }
}