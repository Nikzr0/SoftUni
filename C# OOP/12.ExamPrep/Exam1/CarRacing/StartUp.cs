namespace CarRacing
{
    using Core;
    using Core.Contracts;
    using System.Runtime.Serialization;
    public class StartUp
    {
/*Not entirely working but the structure is great*/
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
