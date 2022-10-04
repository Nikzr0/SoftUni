using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string backingTechnick;
        private double grams;
        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (value == "White" || value == "Wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }


            }
        }
        public string BackingTechnique
        {
            get { return backingTechnick; }
            set
            {
                if (value == "Crispy" || value == "Chewy" || value == "Homemade")
                {
                    backingTechnick = value;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }


            }
        }

        public double Grams
        {
            get { return grams; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                grams = value;
            }
        }

        public Dough(string flourType, string backingTechnick, double grams)
        {
            FlourType = flourType;
            BackingTechnique = backingTechnick;
            Grams = grams;
        }

        public double GetDoughCalories(string flourType, string backingTechnick, double grams)
        {
            double sum = 2 * grams;

            switch (flourType)
            {
                case "White":
                    sum *= 1.5;
                    break;

                case "Wholegrain":
                    sum *= 1.0;
                    break;
            }

            switch (backingTechnick)
            {
                case "Crispy":
                    sum *= 0.9;
                    break;

                case "Chewy":
                    sum *= 1.1;
                    break;

                case "Homemade":
                    sum *= 1.0;
                    break;
            }

            return sum;
        }
    }

    public class Topping
    {
        private string type;
        private double grams;

        public string Type
        {
            get { return type; }
            set
            {
                if (value == "Meat" || value == "Veggies" || value == "Cheese" || value == "Sauce")
                {
                    type = value;
                }
                else
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double Grams
        {
            get { return grams; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new Exception($"{Type} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }

        public Topping(string typeofTopping, double gramsOfTopping)
        {
            Type = typeofTopping;
            Grams = gramsOfTopping;
        }

        public double GetToppingCalories(string typeOfTop, double grams)
        {
            double result = grams * 2;

            switch (typeOfTop)
            {
                case "Meat":
                    result *= 1.2;
                    break;

                case "Veggies":
                    result *= 0.8;
                    break;

                case "Cheese":
                    result *= 1.1;
                    break;

                case "Sauce":
                    result *= 0.9;
                    break;
            }
            return result;
        }
    }
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int count;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public Dough Dought
        {
            get { return dough; }
            set
            {
                dough = value;
            }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public int Count
        {
            get { return count; }
            set
            {
                if (value > 10)
                {
                    throw new Exception("Number of toppings should be in range [0..10].");
                }
                count = value;
            }
        }

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
        }

        public double GetAllCalories(Dough dough, List<Topping> toppings)
        {
            double result = dough.GetDoughCalories(dough.FlourType, dough.BackingTechnique, dough.Grams);

            foreach (var topping in toppings)
            {
                result += topping.GetToppingCalories(topping.Type, topping.Grams);
            }

            return result;
        }
    }
    public class Program
    {
        static void Main()
        {
            string pName = Console.ReadLine().Split(" ")[1];
            Pizza p = new Pizza(pName);
            bool problem = true;

            while (true)
            {
                if (problem)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                        break;
                    }

                    string[] pizza = input.Split(" ");

                    if (pizza[0] == "Pizza")
                    {
                        try
                        {
                            Pizza pica = new Pizza(pizza[1]);
                            pName = pizza[1];
                        }
                        catch (Exception e)
                        {
                            problem = false;
                            Console.WriteLine(e.Message);
                        }
                    }

                    if (pizza[0] == "Dough")
                    {
                        try
                        {
                            string temp = pizza[1];
                            string dType = char.ToUpper(temp[0]) + temp.Substring(1);

                            string temp2 = pizza[2];
                            string bType = char.ToUpper(temp2[0]) + temp2.Substring(1);

                            Dough dough = new Dough(dType, bType, double.Parse(pizza[3]));
                            p.Dought = dough;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                    if (pizza[0] == "Topping")
                    {
                        try
                        {
                            string temp = pizza[1];
                            string tName = char.ToUpper(temp[0]) + temp.Substring(1);
                            Topping topping = new Topping(tName, double.Parse(pizza[2]));
                            p.Toppings.Add(topping);
                            p.Count++;
                        }
                        catch (Exception e)
                        {
                            problem = false;
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            if (problem)
            {
                Console.WriteLine($"{pName} - {p.GetAllCalories(p.Dought, p.Toppings):f2} Calories.");
            }
        }
    }
}