using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6.SongsQueue
{
    public class Program
    {
        public static void Main()
        {
            string[] initialSongs = Console.ReadLine().Split(", ").ToArray();
            List<string> list = new List<string>();
            Queue<string> songsQueue = new Queue<string>();
            Queue<string> tempQueue = new Queue<string>();

            foreach (var item in initialSongs)
            {
                songsQueue.Enqueue(item);
            }

            while (songsQueue.Count > 0)
            {
                string[] command = Console.ReadLine().Split(" ");

                switch (command[0])
                {
                    case "Add":
                        string songName = "";
                        for (int i = 1; i < command.Length; i++)
                        {
                            songName += command[i] + " ";
                        }
                        songName = songName.Substring(0, songName.Length - 1);

                        if (!songsQueue.Contains(songName))
                        {
                            songsQueue.Enqueue(songName);
                        }
                        else
                        {
                            list.Add($"{songName} is already contained!"); // The position can make an ERROR
                        }

                        break;

                    case "Play":
                        songsQueue.Dequeue();
                        break;

                    case "Show":
                        list.Add(string.Join(", ",songsQueue));
                        break;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("No more songs!");
        }
    }
}