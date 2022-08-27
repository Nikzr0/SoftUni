namespace Ex08.Threeuple
{
    public class Threeuple<T,U,Y>
    {
        public T Item1 { get; set; }
        public U Item2 { get; set; }
        public Y Item3 { get; set; }

        public Threeuple()
        {

        }
        public Threeuple(T item1, U item2,Y item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}