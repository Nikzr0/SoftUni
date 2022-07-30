using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> output = new List<string>();
        Dictionary<string, string> user = new Dictionary<string, string>();

        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            string[] command = Console.ReadLine().Split(' ');


            switch (command[0])
            {
                case "register":
                    string name = command[1];
                    string carId = command[2];
                    if (!user.ContainsKey(name))
                    {
                        user.Add(name, carId);

                        output.Add($"{name} registered {carId} successfully"); 
                    }
                    else
                    {
                        output.Add($"ERROR: already registered with plate number {carId}");
                    }
                    break;

                case "unregister":
                    if (user.ContainsKey(command[1]))
                    {
                        output.Add($"{command[1]} unregistered successfully");
                        user.Remove(command[1]);
                    }
                    else
                    {
                        output.Add($"ERROR: user {command[1]} not found");
                    }
                    break;
            }
            n--;
        }


        Console.WriteLine();
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
        foreach (var item in user)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}