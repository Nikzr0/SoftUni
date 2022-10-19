using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public partial class StartUp
    {
        public static class Validator 
        {
            public static bool IsValid(object obj)
            {
                PropertyInfo[] props = obj.GetType().GetProperties();
                bool isValid = false;
                foreach (var item in props)
                {
                    var attributes = item.GetCustomAttributes()
                        .Where(t => t.GetType().IsSubclassOf(typeof(MyValidationAttribute)))                        
                        .ToArray();

                    foreach (MyValidationAttribute attribute in attributes)
                    {
                         isValid = attribute.IsValid(item.GetValue(obj));
                    }
                }

                return isValid;
            }
        }
    }
}