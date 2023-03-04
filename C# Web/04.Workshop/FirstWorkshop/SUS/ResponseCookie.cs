using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SUS.HTTP
{
    public class ResponseCookie : Cookie
    {        
        public ResponseCookie(string name, string value)
            : base(name, value)
        {
            // default value which means accessible to all paths
            this.Path = "/";
        }
        public int MaxAge { get; set; }
        public bool HttpOnly { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name}={this.Value}");

            if (MaxAge != 0) // It's set
            {
                sb.Append($"Max-Age={this.MaxAge}; Path={this.Path};");
            }

            if (this.HttpOnly)
            {
                sb.Append(" HttpOnly;");
            }

            return sb.ToString();
        }

        //A domain can be added
    }
}
