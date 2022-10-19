using System;

namespace ValidationAttributes
{
    public partial class StartUp
    {
        public abstract class MyValidationAttribute : Attribute
        {
            public abstract bool IsValid(object obj);
        }
    }
}
