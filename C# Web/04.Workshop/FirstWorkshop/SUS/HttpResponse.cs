using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.HTTP
{
    public class HttpResponse
    {
        public HttpResponse(string contentType, byte[] body, HttpStatusCode statusCode = HttpStatusCode.Ok)
        {
            if (body == null)
            {
                //throw new ArgumentException(nameof(body));
                //Or if it is null to to replaces with empty body
                body = new byte[0]; // Empty body, but not null
            }

            this.StatusCode = statusCode;// 200 Ok
            this.Body = body; 
            this.Headers = new List<Header>()
            {
                {new Header ("Content-Type", contentType)},
                {new Header ("Content-Length", body?.Length.ToString())} // It is nullable 
            };
            this.Cookies = new List<Cookie> { };
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // We cannot use AppendLine here
            sb.Append($"HTTP/1.1 {(int)this.StatusCode} {this.StatusCode}");
 
            foreach (var header in this.Headers)
            {
                sb.Append(header.ToString() + PublicConstants.NewLine);                
            }

            foreach (var cookie in Cookies)
            {
                sb.Append($"Set-Cookie: " + cookie.ToString() + PublicConstants.NewLine);
            }
            sb.Append(PublicConstants.NewLine);

            return sb.ToString();
        }
        public ICollection<Header> Headers { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public ICollection<Cookie> Cookies { get; set; }
        public byte[] Body { get; set; }
    }
}
