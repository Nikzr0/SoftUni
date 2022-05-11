using System;
using System.Collections.Generic;

class Song
{
    public void Albume(int n)
    {
        List<string> albumeList = new List<string>();
        List<string> titles = new List<string>();

        while (n > 0)
        {
            string input = Console.ReadLine();
            albumeList.Add(input);
            n--;
        }

        string finalInput = Console.ReadLine();

        if (finalInput == "all")
        {
            for (int i = 0; i < albumeList.Count; i++)
            {
                string[] inputArray = albumeList[i].Split('_');
                titles.Add(inputArray[1]);
            }
            Console.WriteLine();
            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            for (int i = 0; i < albumeList.Count; i++)
            {
                string[] inputArray = albumeList[i].Split('_');

                if (inputArray[0] == finalInput)
                {
                    titles.Add(inputArray[1]);
                }
            }
            Console.WriteLine();
            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }
        }

    }

}