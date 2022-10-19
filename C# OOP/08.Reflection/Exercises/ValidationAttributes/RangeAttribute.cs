namespace ValidationAttributes
{
    public partial class StartUp
    {
        public class RangeAttribute : MyValidationAttribute
        {
            private int maxValue;
            private int minValue;
            public RangeAttribute(int minValue, int maxValue)
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
            }

            public override bool IsValid(object obj)
            {
                int inputIntager = (int)obj;
                if (inputIntager < minValue || inputIntager > maxValue)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
