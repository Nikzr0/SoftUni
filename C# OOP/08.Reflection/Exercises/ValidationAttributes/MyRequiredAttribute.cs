namespace ValidationAttributes
{
    public partial class StartUp
    {
        public class MyRequiredAttribute : MyValidationAttribute
        {
            public override bool IsValid(object obj)
            {
                if (obj != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
