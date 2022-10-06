using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex08.CollectionHierarchy
{
    public abstract class CollectionTemplate
    {
        public List<string> Collection { get; set; }
        public CollectionTemplate()
        {
            Collection = new List<string>();
        }
        public virtual int Add(string element)
        {
            Collection.Add(element);
            return Collection.Count - 1;
        }
    }
    public class AddCollection : CollectionTemplate {}
    public class AddremoveCollection : CollectionTemplate
    {
        public override int Add(string element)
        {
            Collection.Insert(0, element);
            return 0;
        }
        public string Remove()
        {
            string result = Collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count - 1);
            return result;
        }
    }
    public class MyList : CollectionTemplate
    {
        public override int Add(string elemenet)
        {
            Collection.Insert(0, elemenet);
            return 0;
        }
        public string Remove()
        {
            string result = Collection[0];
            Collection.RemoveAt(0);
            return result;
        }
        public string Used()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Collection)
            {
                sb.AppendLine(item);
            }
            return sb.ToString().TrimEnd();
        }
    }
    public class Program
    {
        static void Main()
        {
            List<string> collectionOfProducts = Console.ReadLine().Split(" ").ToList();
            int numberOfRemoveOperations = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddremoveCollection addremoveCollection = new AddremoveCollection();
            MyList myList = new MyList();

            string firstLine = "";
            string secondLine = "";
            string thirdLine = "";
            string fourthLine = "";
            string fifthLine = "";

            foreach (var item in collectionOfProducts)
            {
                firstLine += $"{addCollection.Add(item)} ";
            }

            foreach (var item in collectionOfProducts)
            {
                secondLine += $"{addremoveCollection.Add(item)} ";
            }

            foreach (var item in collectionOfProducts)
            {
                thirdLine += $"{myList.Add(item)} ";
            }

            for (int i = 0; i < collectionOfProducts.Count; i++)
            {
                if (i < numberOfRemoveOperations)
                {
                    fourthLine += $"{addremoveCollection.Remove()} ";
                }
            }

            for (int i = 0; i < collectionOfProducts.Count; i++)
            {
                if (i < numberOfRemoveOperations)
                {
                    fifthLine += $"{myList.Remove()} ";
                }
            }

            Console.WriteLine(firstLine.Remove(firstLine.Length-1));
            Console.WriteLine(secondLine.Remove(secondLine.Length - 1));
            Console.WriteLine(thirdLine.Remove(thirdLine.Length - 1));
            Console.WriteLine(fourthLine.Remove(fourthLine.Length - 1));
            Console.WriteLine(fifthLine.Remove(fifthLine.Length - 1));
        }
    }
}