using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03.ShortestPath
{
    public class Program
    {
        // It is not always the shortest
        // Must be optimized

        private static List<List<int>> nodes = new List<List<int>>();
        private static bool conatinsNode;
        private static int index;
        private static int x = -1;
        private static bool stop = false;
        static void Main()
        {
            int numberOfNodes = int.Parse(Console.ReadLine());
            int numberofEdges = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            int count = 0;

            for (int i = 0; i < numberofEdges; i++)
            {
                List<int> node = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                nodes.Add(node);
            }

            int startNodes = int.Parse(Console.ReadLine());
            int endNode = int.Parse(Console.ReadLine());

            for (int i = 0; i < nodes.Count; i++)
            {
                result.Clear();
                index = 0;
                x=0;
                BFS(startNodes, endNode, result, count);
                if (stop)
                {
                    i = nodes.Count;
                }
            }
        }
        private static void BFS(int startNodes, int endNode,
            List<int> result, int count)
        {
            x = 0;
            foreach (var node in nodes)
            {
                x++;
                if (node[0] == startNodes)
                {
                    if (!result.Contains(node[0]))
                    {
                        result.Add(node[0]);
                    }
                    result.Add(node[1]);

                    startNodes = node[1];
                    index = x - 1;
                    count++;
                    conatinsNode = true;

                    if (result.Count > 0 && result[result.Count - 1] == endNode)
                    {
                        Console.WriteLine($"Shortest path length is: {count}");
                        Console.WriteLine(String.Join(" ",result));
                        stop = true;
                        return;
                    }

                    break;
                }

                conatinsNode = false;
            }

            if (!conatinsNode)
            {
                nodes.RemoveAt(index);
                return;
            }

            BFS(startNodes, endNode, result, count);
        }
    }
}