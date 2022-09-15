using System.Diagnostics;
using System.Xml.Linq;

namespace Ex05.Restaurant
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class Food : Product
    {
        public Food()
        {

        }
        public double Grams { get; set; }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
    }

    public class MainDish : Food
    {
        public MainDish()
        {

        }
        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }
    public class Dessert : Food
    {
        public Dessert()
        {        
        }
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
    }

    public class Cake : Dessert
    {
        public Cake()
        {
            Grams = 250;
            Calories = 1000;
            Price = 5;
        }
        public double Calories { get; set; }
        public Cake(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
    }
    public class Starter : Food
    {
        public Starter()
        {

        }
        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }
    public class Soup : Starter
    {
        public Soup()
        {

        }
        public Soup(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }

    public class Fish : MainDish
    {
        public Fish()
        {
            Grams = 22;
        }

        public Fish(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }

    public class Bevarages : Product
    {
        public Bevarages()
        {

        }
        public double Milliliters { get; set; }
        public Bevarages(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
    }

    public class HotBevarages : Bevarages
    {
        public HotBevarages()
        {

        }
        public HotBevarages(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {

        }
    }
    public class ColdBevarages : Bevarages
    {
        public ColdBevarages(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {

        }
    }

    public class Coffee : HotBevarages
    {
        public double CoffeeMilliliters { get; set; }
        public double CoffeePrice { get; set; }
        public double Coffeine { get; set; }

        public Coffee()
        {
            CoffeeMilliliters = 50;
            CoffeePrice = 3.50;
        }
        public Coffee(string name, decimal price, double milliliters, double coffeeMilliliters, double coffeePrice, double coffeine) : base(name, price, milliliters)
        {
            CoffeeMilliliters = coffeeMilliliters;
            CoffeePrice = coffeePrice;
            Coffeine = coffeine;
        }
    }
    public class Tea : HotBevarages
    {
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
    public class Program
    {
        static void Main()
        {

        }
    }
}