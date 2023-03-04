using SUS.HTTP;
using SUS.MsFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            var responseHtml = "<h1>Welcome! </h1>" +
            request.Headres.FirstOrDefault(x => x.Name == "User-Agent ")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }
        public HttpResponse About (HttpRequest request)
        {
            var responseHtml = "<h1>Welcome! </h1>" +
            request.Headres.FirstOrDefault(x => x.Name == "User-Agent ")?.Value;
            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);
            return response;
        }

    }
}
