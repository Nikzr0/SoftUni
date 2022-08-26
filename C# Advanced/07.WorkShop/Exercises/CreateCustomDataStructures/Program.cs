using System;

namespace CreateCustomDataStructures
{
    public class Program
    {
        static void Main()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("ana");
            customList.Add("ana");
            customList.Add("ana");

            for (int i = 0; i < customList.Count; i++)
            {
                Console.WriteLine(customList[i]);
            }
        }
    }
}