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

                string[] command = input.Split(" ");
                string[] foodAndQuantity = Console.ReadLine().Split(" ");

                if (command[0] == "Cat")
                {
                    Cat cat = new Cat(command[1], double.Parse(command[2]));
                    cat.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    cat.ProduceSound();
                    result.Add($"{command[0]}[{command[1]}, {command[4]}, {cat.Weight}, {command[3]}, {cat.FoodEaten}]");
                }
                else if (command[0] == "Tiger")
                {
                    Tiger tiger = new Tiger(command[1], double.Parse(command[2]));
                    tiger.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    tiger.ProduceSound();
                    result.Add($"{command[0]}[{command[1]}, {command[4]}, {tiger.Weight}, {command[3]}, {tiger.FoodEaten}]");
                }
                else if (command[0] == "Dog")
                {
                    Dog dog = new Dog(command[1], double.Parse(command[2])); // abstract
                    dog.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    dog.ProduceSound();
                    result.Add($"{command[0]}[{command[1]}, {dog.Weight}, {command[3]}, {dog.FoodEaten}]");
                }
                else if (command[0] == "Mouse")
                {
                    Mouse mouse = new Mouse(command[1], double.Parse(command[2])); // abstract
                    mouse.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    mouse.ProduceSound();
                    result.Add($"{command[0]}[{command[1]}, {mouse.Weight}, {command[3]}, {mouse.FoodEaten}]");
                }
                else if (command[0] == "Owl")
                {
                    Owl owl = new Owl(command[1], double.Parse(command[2]), double.Parse(command[3])); // abstract
                    owl.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    owl.ProduceSound();
                    result.Add($"{command[0]}[{command[1]}, {owl.WingSize}, {owl.Weight}, {owl.FoodEaten}]");
                }
                else if (command[0] == "Hen")
                {
                    Hen hen = new Hen(command[1], double.Parse(command[2]), double.Parse(command[3])); // abstract
                    hen.Eat(foodAndQuantity[0], double.Parse(foodAndQuantity[1]));
                    hen.ProduceSound();
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