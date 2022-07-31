using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ThePianist
{
    public class Program
    {
        public static void Main()
        {
            int initialPieces = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> dicOfPieces = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, Dictionary<string, string>> dic = new Dictionary<string, Dictionary<string, string>>();
            List<string> list = new List<string>();


            while (initialPieces > 0)
            {
                // {piece}|{composer}|{key}                            
                string[] pieces = Console.ReadLine().Split("|").ToArray();

                dicOfPieces.Add(pieces[0], new Dictionary<string, string>());
                dicOfPieces[pieces[0]].Add(pieces[1], pieces[2]); // {piece}|{composer}{key}

                initialPieces--;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                string[] command = input.Split("|");

                switch (command[0])
                {
                    case "Add":
                        string pieceToAdd = command[1];
                        string composerToAdd = command[2];
                        string keyToAdd = command[3];

                        if (!dicOfPieces.ContainsKey(pieceToAdd))
                        {
                            dicOfPieces.Add(pieceToAdd, new Dictionary<string, string>());
                            dicOfPieces[pieceToAdd].Add(composerToAdd, keyToAdd);

                            list.Add($"{pieceToAdd} by {composerToAdd} in {keyToAdd} added to the collection!");
                        }
                        else
                        {
                            list.Add($"{pieceToAdd} is already in the collection!");
                        }
                        break;

                    case "Remove":
                        string pieceToRemove = command[1];

                        if (dicOfPieces.ContainsKey(pieceToRemove))
                        {
                            dicOfPieces.Remove(pieceToRemove);

                            list.Add($"Successfully removed {pieceToRemove}!");
                        }
                        else
                        {
                            list.Add($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string pieceToChange = command[1];
                        string newKey = command[2];

                        if (dicOfPieces.ContainsKey(pieceToChange))
                        {
                            foreach (var item in dicOfPieces.Where(x => x.Key == pieceToChange))
                            {
                                foreach (var item2 in item.Value)
                                {
                                    dicOfPieces[pieceToChange][item2.Key] = newKey;
                                    break;
                                }
                                break;
                            }

                            list.Add($"Changed the key of {pieceToChange} to {newKey}!");
                        }
                        else
                        {
                            list.Add($"Invalid operation! {pieceToChange} does not exist in the collection.");
                        }

                        break;
                }

            }

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dicOfPieces)
            {
                foreach (var dicValues in item.Value)
                {
                    Console.WriteLine($"{item.Key} -> Composer: {dicValues.Key}, Key: {dicValues.Value}");
                }
            }

        }
    }
}