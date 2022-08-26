namespace Ex02.GenericArrayCreator
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");
            int[] ints = ArrayCreator.Create(5, 12);
        }
    }
}