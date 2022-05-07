using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string comand = Console.ReadLine();

            if (comand == "end")
            {
                break;
            }
            string[] comandArray = comand.Split();

            switch (comandArray[0])
            {
                case "Delete":
                    int deleteElement = int.Parse(comandArray[1]);
                    numbers.Remove(deleteElement);
                    break;

                case "Insert":
                    int insertElement = int.Parse(comandArray[1]);
                    int position = int.Parse(comandArray[2]);
                    numbers.Insert(position, insertElement);
                    break;
            }
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}