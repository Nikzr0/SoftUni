using System;
using System.Collections.Generic;
using System.Text;

namespace SUS.HTTP
{
    public class Cookie
    {
        public Cookie(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
        public Cookie(string cookieAsString)
        {
            // By giving 2 digit in 'Split' we say that we want an array with exactly 2 parts
            var cookieParts = cookieAsString.Split(new char[] {'='}, 2);

            this.Name = cookieParts[0];
            this.Value = cookieParts[1];
        }

        public string Name { get; set; }
        public string Value { get; set; }

        // Overriding
        public override string ToString()
        {
            return $"{this.Name}={this.Value}";
        }
    }
}
