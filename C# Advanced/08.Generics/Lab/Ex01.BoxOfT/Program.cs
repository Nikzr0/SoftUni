using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            box.Add("as");
            box.Add("assd");
            box.Add("ass");
            Console.WriteLine(box.Remove());

            foreach (var item in box.boxes)
            {
                Console.WriteLine(item);
            }
        }
    }
}