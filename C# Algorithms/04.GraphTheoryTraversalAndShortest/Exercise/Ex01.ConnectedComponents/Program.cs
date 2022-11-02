using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Ex01.ConnectedComponents
{
    public class Program
    {
        private static bool[] visited;
        private static List<List<int>> graph;
        static void Main()
        {
            graph = new List<List<int>>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int l = 0; l < numberOfLines; l++)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    graph.Add(new List<int> { });
                }
                else
                {
                    List<int> lineOfNumbers = line.Split(" ").Select(int.Parse).ToList();
                    graph.Add(lineOfNumbers);
                }
            }

            visited = new bool[graph.Count];

            for (int i = 0; i < graph.Count; i++)
            {
                if (visited[i])
                {
                    continue;
                }
                var output = new List<int>();
                DFS(i, output);

                Console.WriteLine($"Connected component: {String.Join(" ", output)}");
            }
        }
        private static void DFS(int i, List<int> components)
        {
            if (visited[i])
            {
                return;
            }

            visited[i] = true;

            foreach (var child in graph[i])
            {
                DFS(child, components);
            }
            components.Add(i);
        }
    }
}