﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Vehicles
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HP { get; set; }

    public Vehicles(string type, string model, string color, int hp)
    {
        Type = type;
        Model = model;
        Color = color;
        HP = hp;
    }


    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Type: {char.ToUpper(Type[0]) + Type.Substring(1)}");
        builder.AppendLine($"Model: {Model}");
        builder.AppendLine($"Color: {Color}");
        builder.AppendLine($"Horsepower: {HP}");
        return builder.ToString().TrimEnd();
    }
}


class Program
{
    static void Main()
    {
        List<Vehicles> vehicles = new List<Vehicles>();
        List<Vehicles> finalVehicles = new List<Vehicles>();
        List<string> vehiclesNames = new List<string>();

        while (true)
        {
            string vehicleInfo = Console.ReadLine();

            if (vehicleInfo == "End")
            {
                break;
            }

            string[] command = vehicleInfo.Split(" "); // {typeOfVehicle} {model} {color} {horsepower}

            Vehicles v = new Vehicles(command[0], command[1], command[2], int.Parse(command[3]));
            v.Type = command[0];
            v.Model = command[1];
            v.Color = command[2];
            v.HP = int.Parse(command[3]);
            vehicles.Add(v);
        }

        while (true)
        {
            string vehicleName = Console.ReadLine();

            if (vehicleName == "Close the Catalogue")
            {
                break;
            }

            vehiclesNames.Add(vehicleName);
        }

        //  HORESEPOWER COUNTER
        double avarageHpOfCars = 0;
        double avarageHpOfTrucks = 0;

        int carsCounter = 0;
        int trucksCounter = 0;

        foreach (var item in vehicles)
        {
            if (item.Type == "car")
            {
                avarageHpOfCars = avarageHpOfCars + item.HP;
                carsCounter++;
            }
            else
            {
                avarageHpOfTrucks = avarageHpOfTrucks + item.HP;
                trucksCounter++;
            }
        }

        foreach (var item in vehiclesNames)
        {

            foreach (var item1 in vehicles)
            {
                if (item1.Model == item)
                {
                    finalVehicles.Add(item1);
                }
            }
        }

        foreach (var item in finalVehicles)
        {
            Console.WriteLine(item);
        }

        // AVARAGE HORSEPOWER
        Console.WriteLine($"Cars have average horsepower of: {avarageHpOfCars / carsCounter:f2}.");
        Console.WriteLine($"Trucks have average horsepower of: {avarageHpOfTrucks / trucksCounter:f2}.");
    }
}