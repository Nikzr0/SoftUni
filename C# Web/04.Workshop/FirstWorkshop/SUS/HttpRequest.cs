using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SUS.HTTP
{
    public class HttpRequest
    {
        // All the logic in the constructor
        public HttpRequest(string requestString)
        {
            // To prevent NoReferenceException
            this.Headres = new List<Header>();
            this.Cookies = new List<Cookie>();

            var lines = requestString.Split(new string[] { PublicConstants.NewLine }, StringSplitOptions.None);
            var headerLine = lines[0];
            var headerLineParts = headerLine.Split(' ');

            //Header
            this.Method = headerLineParts[0];
            this.Path = headerLineParts[1];

            int lineIndex = 1;
            bool isInHeaders = true;
            StringBuilder sb = new StringBuilder();

            //BodyF
            while (lineIndex < lines.Length)
            {
                var line = lines[lineIndex];

                lineIndex++;

                if (string.IsNullOrWhiteSpace(line))
                {
                    isInHeaders = false;
                    continue;
                }

                if (isInHeaders)
                {
                    this.Headres.Add(new Header(line));
                }
                else
                {
                    sb.AppendLine(line);
                }
            }

            if (this.Headres.Any(x=> x.Name == PublicConstants.RequestCookieHeader))
            {
                var stringOfCookies = this.Headres
                    .FirstOrDefault(x => x.Name == "Cookie").Value;
                var cookies = stringOfCookies
                    .Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var cookie in cookies)
                {
                    this.Cookies.Add(new Cookie(cookie));
                }
            }

            this.Body = sb.ToString();
        }
        public string Path { get; set; }
        public string Method { get; set; }
        public List<Header> Headres { get; set; }
        public List<Cookie> Cookies { get; set; }
        public string Body { get; set; }
    }
}
