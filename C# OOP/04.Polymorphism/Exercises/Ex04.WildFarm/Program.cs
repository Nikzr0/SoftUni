using System;
using System.Collections.Generic;
using Ex04.WildFarm.Birds;
using Ex04.WildFarm.Mammals;

namespace Ex04.WildFarm
{
    public class Program
    {
        /*
        - Surely not the best way to solve the task!
        - Not 100%
        - I didn't use any of the food classes!
        */
        static void Main()
        {
            List<string> result = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                Animal animal = null;

                string[] command = input.Split(" ");
                string[] foodAndQuantity = Console.ReadLine().Split(" ");

                if (command[0] == "Cat")
                {
                    animal = new Cat(command[1], double.Parse(command[2]));
                    animal.ProduceSound();
                    animal.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    result.Add($"{command[0]}[{command[1]}, {command[4]}, {animal.Weight}, {command[3]}, {animal.FoodEaten}]");
                }
                else if (command[0] == "Tiger")
                {
                    animal = new Tiger(command[1], double.Parse(command[2]));
                    animal.ProduceSound();
                    animal.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    result.Add($"{command[0]}[{command[1]}, {command[4]}, {animal.Weight}, {command[3]}, {animal.FoodEaten}]");
                }
                else if (command[0] == "Dog")
                {
                    animal = new Dog(command[1], double.Parse(command[2])); // abstract
                    animal.ProduceSound();
                    animal.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    result.Add($"{command[0]}[{command[1]}, {animal.Weight}, {command[3]}, {animal.FoodEaten}]");
                }
                else if (command[0] == "Mouse")
                {
                    animal = new Mouse(command[1], double.Parse(command[2])); // abstract
                    animal.ProduceSound();
                    animal.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    result.Add($"{command[0]}[{command[1]}, {animal.Weight}, {command[3]}, {animal.FoodEaten}]");
                }
                else if (command[0] == "Owl")
                {
                    Owl owl = new Owl(command[1], double.Parse(command[2]), double.Parse(command[3])); // abstract
                    owl.ProduceSound();
                    owl.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1])); ;
                    result.Add($"{command[0]}[{command[1]}, {owl.WingSize}, {owl.Weight}, {owl.FoodEaten}]");
                }
                else if (command[0] == "Hen")
                {
                    Hen hen = new Hen(command[1], double.Parse(command[2]), double.Parse(command[3])); // abstract
                    hen.ProduceSound();
                    hen.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    result.Add($"{command[0]}[{command[1]}, {hen.WingSize}, {hen.Weight}, {hen.FoodEaten}]");
                }
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}