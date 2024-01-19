namespace WebApplication24.Serivice
{
    public class ShortService : IShortSevice
    {
        public string GetShortDescription(string text, int maxLenth)
        {
            if (text == null || text.Length <= maxLenth)
            {
                return text;
            }
            else
            {
                return text.Substring(0, maxLenth) + "...";
            }
        }
    }
}
